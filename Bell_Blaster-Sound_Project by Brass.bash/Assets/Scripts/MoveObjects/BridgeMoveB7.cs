using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMoveB7 : MonoBehaviour {

    // Use this for initialization
    private Vector3 normal;
    // Use this for initialization
    void Start()
    {
        normal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.currentNote == GameManager.BellNotes.B7)
        {
            transform.position = new Vector3(normal.x + 19.49f, normal.y + 3.0f, normal.z - 6.38f);
            transform.rotation = Quaternion.Euler(0, 90, 0);
           
        }
        else
        {
            transform.position = normal;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
