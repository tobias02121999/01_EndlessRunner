using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_terrainMovement : MonoBehaviour {

    //References
    private GameObject gameManager;

    public float terrainMovSpeed;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * -terrainMovSpeed * Time.deltaTime);
        Debug.Log(terrainMovSpeed);
    }

}
