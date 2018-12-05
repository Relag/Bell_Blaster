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

        score = 0;                          // pick up score starts at 0
        SetScoreText ();

        //completedLevelText.text = "";     // uncomment this once the UI is made 
	}

    void OnTriggerEnter(Collider other)
    {
            myAudio.clip = purpleNote;

            score += 1;
            SetScoreText();
            gameObject.SetActive(false);
            Destroy(gameObject);
            Debug.Log("HitPurpleNote");
       
        if (other.gameObject.CompareTag("Blue"))
        {
            myAudio.clip = blueNote;

            score += 1;
            SetScoreText();
            other.gameObject.SetActive(false);
            Destroy(gameObject);
            gameObject.SetActive(false);
            Debug.Log("HitBlueNote");
        }
        
    }

    void SetScoreText()
    {
        // once all 7 pickups are picked up with or without the bonus purple notes,
        // a text will appear on the UI
        if (score >= 7  || score <= 10) 
        {
            // uncomment this once the UI is made
            //completedLevelText.text = "Congrats, you have completed the level!" w+
            //"Please proceed through the doorway";
        }
    }
}
