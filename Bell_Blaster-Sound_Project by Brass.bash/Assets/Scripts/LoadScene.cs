using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public string scenePath;
    
    // Loads the scene of the given path
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(scenePath, LoadSceneMode.Single);
    }
}
