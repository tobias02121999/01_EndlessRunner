using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCollider : MonoBehaviour {

    //Reference
    private GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "TerrainPrefabCollider")
        {
            Destroy(other.gameObject);
        }
    }

}
