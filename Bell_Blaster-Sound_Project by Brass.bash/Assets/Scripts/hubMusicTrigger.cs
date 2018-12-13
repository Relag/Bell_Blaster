/* The Following script takes care of the music triggered soon as the player enters in the trigger zone.
   Hungarion notation is used to to name int and floats here*/

using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;


public class hubMusicTrigger : MonoBehaviour {

    [Space]
    public AudioMixerSnapshot outOfTriggerZone;
    public AudioMixerSnapshot insideTriggerZone;
    public float fBpm = 120;                     //beats per minute for music

    [SerializeField]
    private AudioSource anyAudioSource;

    int musicCounter = 0;                       // Keeps track of the triggerZone number and the music to pull

    private float fTransitionIn;                
    private float fTransitionOut;
    private float fQuarterNote;

	// Use this for initialization
	void Start ()
    {
        fQuarterNote = 60 / fBpm;               //Get the value for quarterNote using the bpm value
        fTransitionIn = fQuarterNote;
        fTransitionOut = fQuarterNote * 32;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("triggerZone1"))
        {
            Debug.Log("triggerZone trigger enter");
            insideTriggerZone.TransitionTo(fTransitionIn);
            musicCounter = 0;
        }
        else if (collider.CompareTag("triggerZone2"))
        {
            Debug.Log("triggerZone trigger enter");
            insideTriggerZone.TransitionTo(fTransitionIn);
            musicCounter = 1;
        }
        else if (collider.CompareTag("triggerZone3"))
        {
            Debug.Log("triggerZone trigger enter");
            insideTriggerZone.TransitionTo(fTransitionIn);
            musicCounter = 2;
        }
        PlayLevelMusic(musicCounter);                       
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("triggerZone1") || collider.CompareTag("triggerZone2") || collider.CompareTag("triggerZone3"))
        {
            Debug.Log("triggerZone trigger exit");
            outOfTriggerZone.TransitionTo(fTransitionOut);
        }
    }

    void PlayLevelMusic( int x )
    {
        // Works with the soundManager, pulls up 
        SoundManager.Instance.PlayMusic(x,anyAudioSource);
    }

}
