using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour {

    private Vector3 normal;
	// Use this for initialization
	void Start () {
        normal = transform.position;

        
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (GameManager.Instance.currentNote == GameManager.BellNotes.D2)
        {
            transform.position = new Vector3(normal.x + 5, normal.y, normal.z);
            GetComponent<AudioSource>().maxDistance = 100;
            SoundManager.Instance.PlayHarmonic(1, GetComponent<AudioSource>());
        }
        else
        {
            transform.position = normal;
            
        }
	}
}
