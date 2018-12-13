using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoveD2 : MonoBehaviour {

    private Vector3 normal;
    // Use this for initialization
    void Start()
    {
        normal = transform.position;
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.currentNote == GameManager.BellNotes.D2)
        {
            transform.position = new Vector3(normal.x, normal.y - 5.2f, normal.z);
            GetComponent<AudioSource>().maxDistance = 50;
        }
        else
        {
            transform.position = normal;
            GetComponent<AudioSource>().maxDistance = 5;
        }
    }
}
