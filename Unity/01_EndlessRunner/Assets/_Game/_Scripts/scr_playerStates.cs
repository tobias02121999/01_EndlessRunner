using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Initialize the enum variable to store the different player states in
enum states { DEFAULT, HIT }

public class scr_playerStates : MonoBehaviour {

    // Initialize the private variables
    private scr_playerFunctions playerFunctions;
    private scr_playerStats playerStats;
    private states playerState = states.DEFAULT;

	// Use this for initialization
	void Start ()
    {
        // Link the player functions script to a variable
        playerFunctions = GetComponent<scr_playerFunctions>();

        // Link the player stats script to a variable
        playerStats = GetComponent<scr_playerStats>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Run the player state function
        runState(playerState);
    }

    // Run the player state according to the given argument
    void runState(states stateName)
    {
        // Scroll through all of the player states, and run the functions corresponding to the given state name
        switch (stateName)
        {
            // The default player state
            case states.DEFAULT:

                playerFunctions.playerMovement(Input.GetAxis(playerStats.axisHorizontal), 0f, playerStats.movementSpeed);
                playerFunctions.allignToSurface(.25f);
                playerFunctions.playerDash(Input.GetAxis(playerStats.axisHorizontal), 0f, Input.GetAxis(playerStats.buttonDash), playerStats.dashForce, playerStats.dashDampening, playerStats.worldTransform);
                playerFunctions.setInvulnerability(playerStats.playerMaterial, playerStats.invulnerabilityMaterial, false);

                if (playerFunctions.obstacleHitCheck())
                    playerState = states.HIT;

                break;

            case states.HIT:

                playerFunctions.playerMovement(0f, -.5f, playerStats.movementSpeed);
                playerFunctions.allignToSurface(.25f);
                playerFunctions.setInvulnerability(playerStats.playerMaterial, playerStats.invulnerabilityMaterial, true);

                if (playerFunctions.checkPositionTrigger(-6.5f))
                    playerState = states.DEFAULT;

                Debug.Log(playerFunctions.checkPositionTrigger(-6.5f));
                Debug.Log(transform.position.z);

                break;
        }
    }
}
