using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* NB: Attach this script to the player. Ensure that the player, or child-object has an audiosource. The public int
  corresponds to the array of music found in SoundManager.cs.  */ 
public class BackGroundMusic : MonoBehaviour {

    private AudioSource BGM;
    public int songNumber;

	// Use this for initialization
	void Start ()
    {
        BGM = GetComponent<AudioSource>();
        SoundManager.Instance.PlayMusic(songNumber, BGM);
	}
}
