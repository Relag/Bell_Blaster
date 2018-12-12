using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMoveC1 : MonoBehaviour {

    private Vector3 normal;
    // Use this for initialization
    void Start()
    {
        normal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.currentNote == GameManager.BellNotes.C1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position = new Vector3(normal.x - 12.22f, normal.y - 3.5f, normal.z + 8.15f);
        }
        else
        {
            transform.position = normal;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }
}
