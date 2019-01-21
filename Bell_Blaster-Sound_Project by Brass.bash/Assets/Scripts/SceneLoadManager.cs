using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour {

    Scene scene;
    private int nodesAvailable;
    public Collider player;
    

    public static SceneLoadManager Instance;        //singleton pattern

    // Use this for initialization
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void FixedUpdate()
    {
        // fetch the active scene index and store it in levelIndex
        scene = SceneManager.GetActiveScene();
    }

    void ScorePerScene()
    {
        if (scene.name == "Rejean")
        {
            nodesAvailable = 4;

            // checks if in active scene all nodes are picked up then go to hub
            if (GameManager.Instance.score >= nodesAvailable)
            {
                GameManager.Instance.score = 0;
                SceneManager.LoadScene("Hub");
            }
        }
        if (scene.name == "Charles")
        {
            nodesAvailable = 10;

            // checks if in active scene all nodes are picked up then go to hub
            if (GameManager.Instance.score >= nodesAvailable)
            {
                GameManager.Instance.score = 0;     
                SceneManager.LoadScene("Hub");
            }
        }
        if (scene.name == "Nick")
        {
            nodesAvailable = 8;

            // checks if in active scene all nodes are picked up then go to hub
            if (GameManager.Instance.score >= nodesAvailable)
            {
                GameManager.Instance.score = 0;
                SceneManager.LoadScene("Hub");
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "levelCube1")
        {
            Debug.Log("Level trigger enter");
            SceneManager.LoadScene("Rejean");
        }
        else if (collider.name == "levelCube2")
        {
            Debug.Log("Level trigger enter");
            SceneManager.LoadScene("Charles");
        }
        else if (collider.CompareTag("levelCube3"))
        {
            Debug.Log("Level trigger enter");
            SceneManager.LoadScene("Nick");
        }
    }
}
