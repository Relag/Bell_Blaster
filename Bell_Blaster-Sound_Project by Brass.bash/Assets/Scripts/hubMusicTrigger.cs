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
        if (collider.CompareTag("triggerZone"))
        {
            Debug.Log("triggerZone triggered");
            insideTriggerZone.TransitionTo(fTransitionIn);
        }
        PlayLevelMusic();                       
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("triggerZone"))
        {

            Debug.Log("triggerZone triggered");

            outOfTriggerZone.TransitionTo(fTransitionOut);
        }
    }

    void PlayLevelMusic()
    {
        SoundManager.Instance.PlayMusic(0,anyAudioSource);
    }

}
