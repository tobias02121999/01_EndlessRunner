using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCollider : MonoBehaviour {

    //Reference
    private GameObject gameManager;
    private scr_terrainSpeed terrainSpeed;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        terrainSpeed = gameManager.GetComponent<scr_terrainSpeed>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "TerrainPrefabCollider")
        {
            terrainSpeed.terrainMovSpeed += 1f;
            Destroy(other.gameObject);
        }
    }

}
