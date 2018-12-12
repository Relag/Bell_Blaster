using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trumpet : MonoBehaviour
{
	public Transform TrumpetEnd;
	public Camera camera;

	void Start()
	{
		
	}

	
	void Update()
	{
		//fire a "projectile" from the trumpet
		if (Input.GetMouseButtonDown(0))
		{
			//this will depends on Yash creating an animation or not
		//StartCoroutine(SoundWaveEffect());
                //Joel's Script
		    //Vector3 rayOrigin = PlayerPosition.ViewportToWorldPoint (new Vector3 (.5f, .5f, 0));
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            //Create Raycast
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                switch (hit.transform.gameObject.tag)
                {
                    case "C1":
                        //Call SoundManager to play bell (temp)
                        SoundManager.Instance.RingBell(0, GetComponent<AudioSource>());
                        //Change currentNote Enum in GameManager
                        GameManager.Instance.currentNote = GameManager.BellNotes.C1;
                        break;
                    case "D2":
                        SoundManager.Instance.RingBell(1, GetComponent<AudioSource>());
                        GameManager.Instance.currentNote = GameManager.BellNotes.D2;
                        break;
                    case "E3":
                        SoundManager.Instance.RingBell(2, GetComponent<AudioSource>());
                        GameManager.Instance.currentNote = GameManager.BellNotes.E3;
                        break;
                    case "F4":
                        SoundManager.Instance.RingBell(3, GetComponent<AudioSource>());
                        GameManager.Instance.currentNote = GameManager.BellNotes.F4;
                        break;
                    case "G5":
                        SoundManager.Instance.RingBell(4, GetComponent<AudioSource>());
                        GameManager.Instance.currentNote = GameManager.BellNotes.G5;
                        break;
                    case "A6":
                        SoundManager.Instance.RingBell(5, GetComponent<AudioSource>());
                        GameManager.Instance.currentNote = GameManager.BellNotes.A6;
                        break;
                    case "B7":
                        SoundManager.Instance.RingBell(6, GetComponent<AudioSource>());
                        GameManager.Instance.currentNote = GameManager.BellNotes.B7;
                        break;
                    case "C8":
                        SoundManager.Instance.RingBell(7, GetComponent<AudioSource>());
                        GameManager.Instance.currentNote = GameManager.BellNotes.C8;
                        break;
                }
            }
		}
	}

}
