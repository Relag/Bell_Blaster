using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioClip[] bellSounds;

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

    public void RingBell(int x, AudioSource playFrom)
    {
        playFrom.loop = false;
        playFrom.PlayOneShot(bellSounds[x]);
    }

    public void PlayMusic(int x, AudioSource playFrom)
    {
        playFrom.loop = true;
        playFrom.clip = BGM[x];
        playFrom.Play();
    }

}
