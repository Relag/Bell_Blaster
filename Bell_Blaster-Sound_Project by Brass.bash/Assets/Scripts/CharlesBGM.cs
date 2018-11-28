using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharlesBGM : MonoBehaviour {

    public AudioSource BGMC;

	void Start ()
    {
        BGMC = GetComponent<AudioSource>();
        SoundManager.Instance.PlayMusic(0, BGMC);
	}
	
	void Update ()
    {
		
	}
}
