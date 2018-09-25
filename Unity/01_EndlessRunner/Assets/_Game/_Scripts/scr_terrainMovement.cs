using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_terrainMovement : MonoBehaviour {

    //References
    private GameObject gameManager;
    private scr_terrainSpeed terrainSpeed;

    public float terrainMovSpeed;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        terrainSpeed = gameManager.GetComponent<scr_terrainSpeed>();
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * -terrainSpeed.terrainMovSpeed * Time.deltaTime);
        Debug.Log(terrainSpeed.terrainMovSpeed);
    }

}
