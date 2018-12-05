using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotePickUp : MonoBehaviour
{
    private Text scoreText;             // score text for the UI
    private Text completedLevelText;
    private int score;
    private AudioSource myAudio;

    public AudioClip purpleNote;        // once the purple note is picked up, play deep note
    public AudioClip blueNote;
    public AudioClip whiteNote;
    public AudioClip redNote;
    public AudioClip yellowNote;
    public AudioClip orangeNote;
    public AudioClip greenNote;
    void Start ()
    {
        myAudio = GetComponent<AudioSource>();

        score = 0;                      // pick up score starts at 0
        SetScoreText ();

        completedLevelText.text = "";
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Purple note"))
        {
            other.gameObject.SetActive(false);
            myAudio.Play();

            score += 1;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Blue Note"))
        {
            myAudio.PlayOneShot(blueNote);
        }
    }

    void SetScoreText()
    {
        // once all 7 pickups are picked up with or without the bonus purple notes,
        // a text will appear on the UI
        if (score >= 7  || score <= 10) 
        {
            // uncomment this once the UI is made
            //completedLevelText.text = "Congrats, you have completed the level!" +
            //"Please proceed through the doorway";
        }
    }
}
