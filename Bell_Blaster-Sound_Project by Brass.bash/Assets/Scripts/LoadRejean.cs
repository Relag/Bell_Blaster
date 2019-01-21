using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRejean : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
   
        if (collider.tag == "Player")
        {
            
            Debug.Log("Level trigger enter");
            SceneManager.LoadScene("Rejean");
        }
    }
    }
