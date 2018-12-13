using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour {

    private int levelIndex;         //stores the level index

    public void FixedUpdate()
    {
        // fetch the active scene index and store it in levelIndex
        levelIndex = SceneManager.GetActiveScene().buildIndex;
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("levelCube1"))
        {
            Debug.Log("triggerZone trigger enter");
            SceneManager.LoadScene(1);
        }
        else if (collider.CompareTag("levelCube2"))
        {
            Debug.Log("triggerZone trigger enter");
            SceneManager.LoadScene(2);
        }
        else if (collider.CompareTag("levelCube3"))
        {
            Debug.Log("triggerZone trigger enter");
            SceneManager.LoadScene(3);
        }
    }



}
