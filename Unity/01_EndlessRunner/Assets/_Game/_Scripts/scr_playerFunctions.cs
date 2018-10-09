using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerFunctions : MonoBehaviour {

    // Initialize the private variables
    private Rigidbody playerRigidbody;
    private Renderer playerRenderer;
    private bool isDashing;
    private bool obstacleIsHit;
    private float dashSpeed;

	// Use this for initialization
	void Start ()
    {
        // Link the players rigidbody to a variable
        playerRigidbody = GetComponent<Rigidbody>();
        playerRenderer = GetComponentInChildren<Renderer>();
	}

    // Move the player around based on the given arguments
    public void playerMovement(float inputHorizontal, float inputVertical, float movementSpeed)
    {
        // Store the player vector movement in a new Vector3 variable
        Vector3 v3 = ((transform.right * (inputHorizontal * (movementSpeed * 100f))) + (transform.forward * (inputVertical * (movementSpeed * 100f)))) * Time.deltaTime;
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
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.FromToRotation(Vector3.up, hit.normal), 2.5f);
    }

    // Dash the player towards his/her current movement direction
    public void playerDash(float inputHorizontal, float inputVertical, float inputDash, float dashForce, float dashDampening, Transform worldTransform)
    { 
        if (inputDash != 0f && !isDashing)
        {
            dashSpeed = 1f;
            isDashing = true;
        }

        if (inputDash == 0f)
            isDashing = false;

        if (dashSpeed >= dashDampening)
            dashSpeed -= dashDampening;

        // Add force to the players rigidbody in order to make him/her dash
        playerRigidbody.AddForce(((worldTransform.right * inputHorizontal * (dashForce * 100f)) + (worldTransform.forward * inputVertical * (dashForce * 100f))) * dashSpeed);
    }

    // Check for collision
    void OnCollisionEnter(Collision collision)
    {
        // Check for collision with objects tagged as 'Obstacle'
        if (collision.gameObject.tag == "Obstacle")
            obstacleIsHit = true; // Tell the player that it is currently colliding with an obstacle
        else
            obstacleIsHit = false; // Tell the player that it is currently not colliding with an obstacle
    }

    // Return if the player is currently colliding with an obstacle
    public bool obstacleHitCheck()
    {
        return obstacleIsHit;
    }


    // Activate or deactivate the player properties required for the 'invulnerability' state
    public void setInvulnerability(Material playerMaterial, Material invulnerabilityMaterial, bool activated)
    {
        if (activated) // If the player is invulnerable
        {
            playerRigidbody.useGravity = false;
            GetComponent<BoxCollider>().enabled = false;
            playerRenderer.material = invulnerabilityMaterial;
        } 
        else
        {
            playerRigidbody.useGravity = true;
            GetComponent<BoxCollider>().enabled = true;
            playerRenderer.material = playerMaterial;
        }
    }

    public bool checkPositionTrigger(float positionZ)
    {
        if (transform.localPosition.z <= positionZ)
            return true;
        else
            return false;
    }
}
