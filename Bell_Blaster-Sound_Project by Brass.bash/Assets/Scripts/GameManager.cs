using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public enum  BellNotes { C1, D2, E3, F4, G5, A6, B7, C8}
    public BellNotes currentNote;
    private int score;
    public static GameManager Instance;

	// Use this for initialization
	void Awake () {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
