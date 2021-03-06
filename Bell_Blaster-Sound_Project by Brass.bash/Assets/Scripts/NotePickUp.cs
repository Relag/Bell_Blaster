﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotePickUp : MonoBehaviour
{
    public Text scoreText;             // score text for the UI
    private Text completedLevelText;
    private AudioSource myAudio;


    public AudioClip purpleNote;        // once the purple note is picked up, play deep note
    public AudioClip blueNote;
    public AudioClip whiteNote;
    public AudioClip redNote;
    public AudioClip yellowNote;
    public AudioClip orangeNote;
    public AudioClip greenNote;
    public AudioClip cyanNote;
    void Start ()
    {
        myAudio = GetComponent<AudioSource>();

        GameManager.Instance.score = 0;                          // pick up score starts at 0
        SetScoreText ();

        //completedLevelText.text = "";     // uncomment this once the UI is made 
	}

    void OnTriggerEnter(Collider other)
    {
        SoundManager.Instance.PlayHarmonic(8, myAudio);

        gameObject.GetComponent<SphereCollider>().isTrigger = false;

            GameManager.Instance.score += 1;
            SetScoreText();
            StartCoroutine ("DestroyPickup");
            Debug.Log("HitPurpleNote");
       
        if (other.gameObject.CompareTag("Blue"))
        {
            myAudio.clip = blueNote;

            GameManager.Instance.score += 1;
            SetScoreText();
            other.gameObject.SetActive(false);
            Destroy(gameObject);
            gameObject.SetActive(false);
            Debug.Log("HitBlueNote");
        }
        
    }

    IEnumerator DestroyPickup()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    void SetScoreText()
    {
        // Updates the score with current.
        scoreText.text = "Score: " + GameManager.Instance.score;

        if (GameManager.Instance.score >= 7  || GameManager.Instance.score <= 10) 
        {
            // uncomment this once the UI is made
            //completedLevelText.text = "Congrats, you have completed the level!" w+
            //"Please proceed through the doorway";
        }
    }
}
