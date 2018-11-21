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

		Vector3 rayOrigin = PlayerPosition.ViewportToWorldPoint (new Vector3 (.5f, .5f, 0));
		}
	}

}
