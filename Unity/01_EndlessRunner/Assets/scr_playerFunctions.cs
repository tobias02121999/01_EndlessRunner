using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerFunctions : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    // Move the player around based on the given arguments
    public void playerMovement(float movementSpeedRight, float movementSpeedForward)
    {
        // Apply the given arguments to the player position
        transform.position += ((transform.right * movementSpeedRight) + (transform.forward * movementSpeedForward)) * Time.deltaTime;
    }
}
