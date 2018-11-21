/* To use this script, create two empty game objects. One is the point the player warps from, the other is the point 
 * the player warps to. Give the Warpfrom point a box collider where a player may fall. Attatch this script to 
 * the warpfrom object. Then, position the Warpto game object to where you want to place the player, and drag it to 
 * the public variable "startPoint."
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallReset : MonoBehaviour {

    public Transform startPoint;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = startPoint.position;
    }
}
