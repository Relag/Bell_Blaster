using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trumpet : MonoBehaviour
{
	public Transform TrumpetEnd;
	public Camera PlayerPosition;

	void Start()
	{
		PlayerPosition = GetComponentInParent<Camera> ();
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
            //Create Raycast
            if (Physics.Raycast(transform.position, Vector3.forward, out hit, 100.0f))
            {
                //Trying to draw debug raycast
                Debug.DrawRay(transform.position, Vector3.forward, Color.cyan);
                //Call SoundManager to play bell (temp)
                SoundManager.Instance.RingBell(0, GetComponent<AudioSource>());
                //Change currentNote Enum in GameManager
                GameManager.Instance.currentNote = GameManager.BellNotes.D2;
            }
            else
            {
                Debug.DrawRay(transform.position, Vector3.forward, Color.black);
                 SoundManager.Instance.RingBell(0, GetComponent<AudioSource>());
            }
		}
	}

}
