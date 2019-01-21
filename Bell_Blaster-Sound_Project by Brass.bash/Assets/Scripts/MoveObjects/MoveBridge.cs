using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBridge : MonoBehaviour
{

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
        if (GameManager.Instance.currentNote == GameManager.BellNotes.F4)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.position = new Vector3(normal.x + 15, normal.y, normal.z + 22);
        }
        else if (GameManager.Instance.currentNote == GameManager.BellNotes.G5)
        {
            transform.position = new Vector3(normal.x + 42, normal.y, normal.z);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.position = normal;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
        }
    }
}