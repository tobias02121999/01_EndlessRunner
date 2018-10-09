using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerStats : MonoBehaviour {

    // Initialize the public variables
    public Transform worldTransform;

    public string axisHorizontal;
    public string axisVertical;
    public string buttonDash;
    public float movementSpeed;
    public float dashForce;
    public float dashDampening;
    public int rowID = 0;

    public Material playerMaterial;
    public Material invulnerabilityMaterial;
}
