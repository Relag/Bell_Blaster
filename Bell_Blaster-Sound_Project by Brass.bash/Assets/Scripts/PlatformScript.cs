using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour {

    public GameObject[] platforms;
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i <= 7; i++)
        {
            if(platforms[i].tag == GameManager.Instance.currentNote.ToString())
            {
                platforms[i].SetActive(true);
            }
            else
            {
                platforms[i].SetActive(false);
            }
        }
	}
}
