using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour {

    public AudioSource BGM;

	// Use this for initialization
	void Start ()
    {
        BGM = GetComponent<AudioSource>();
        SoundManager.Instance.PlayMusic(0, BGM);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
