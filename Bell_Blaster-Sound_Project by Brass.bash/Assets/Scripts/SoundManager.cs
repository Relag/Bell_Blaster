using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    // Array for all the Bell Sounds
    public AudioClip[] bellSounds;

    //Array for all the Music
    public AudioClip[] BGM;

    public static SoundManager Instance;
	// Use this for initialization
	void Awake ()
    {
	    if(Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad (gameObject);
	}

    //Function to play bell sound Effects:  SoundManager.Instance.PlayMusic(0, BGM); To Use
    public void RingBell(int x, AudioSource playFrom)
    {
        playFrom.loop = false;
        playFrom.PlayOneShot(bellSounds[x]);
    }

    //Function to play Background Music:  SoundManager.Instance.PlayMusic(Clip, AudioSource); To Use
    public void PlayMusic(int x, AudioSource playFrom)
    {
        playFrom.loop = true;
        playFrom.clip = BGM[x];
        playFrom.Play();
    }

}
