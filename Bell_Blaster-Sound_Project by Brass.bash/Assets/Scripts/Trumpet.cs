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


	public void TrumpetShoot()
	{
		if (Input.GetMouseButtonDown(0))
		{
			
		}
	}

	void Update()
	{
		StartCoroutine(SoundWaveEffect());

		Vector3 rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3 (.5f, .5f, 0));
	}
}
