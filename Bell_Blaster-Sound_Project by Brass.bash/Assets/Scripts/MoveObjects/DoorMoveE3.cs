using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoveE3 : MonoBehaviour {

    private Vector3 normal;
	// Use this for initialization
	void Start () {
        normal = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
    if (GameManager.Instance.currentNote == GameManager.BellNotes.E3)
    {
        transform.position = new Vector3(normal.x, normal.y - 5.2f, normal.z);
    }
    else
    {
        transform.position = normal;
    }
}
}
