using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExitHider : MonoBehaviour {

    public GameObject sceneExit;

    private void Update()
    {
        if(GameManager.Instance.score >= 8)
        {
            sceneExit.SetActive(true);
        }
        else
        {
            sceneExit.SetActive(false);
        }
    }
}
