using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerFunctions : MonoBehaviour {

    // Initialize the private variables
    private Rigidbody playerRigidbody;

	// Use this for initialization
	void Start ()
    {
        // Link the players rigidbody to a variable
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    // Move the player around based on the given arguments
    public void playerMovement(float movementSpeedRight, float movementSpeedForward)
    {
        // Store the player vector movement in a new Vector3 variable
        Vector3 v3 = ((transform.right * (movementSpeedRight * 100f)) + (transform.forward * (movementSpeedForward * 100f))) * Time.deltaTime;
        v3.y = playerRigidbody.velocity.y; // Reset the Y velocity to make sure it doesn't skip gravity appliance
        playerRigidbody.velocity = v3; // Apply the velocity variable to the rigidbody velocity of the player
    }

    // Allign the players rotation to match the surface underneith him/her
    public void allignToSurface(float distance)
    {
        // Initialize the RaycastHit variable
        RaycastHit hit;

        // Initialize the castPos variable (the direction in which the raycast will be casted)
        Vector3 castPos = new Vector3(transform.position.x, transform.position.y - distance, transform.position.z);

        // Perform a Raycast check based on the given arguments
        if (Physics.Raycast(castPos, -transform.up, out hit))
            transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal); // Allign the player to match the detected surface
    }
}
