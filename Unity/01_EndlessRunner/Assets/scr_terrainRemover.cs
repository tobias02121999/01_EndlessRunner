using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_terrainRemover : MonoBehaviour {

    public GameObject gameManager;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "TerrainRemoveCollider")
        {
            gameManager.GetComponent<scr_gameManager>().globalMovementSpeed += gameManager.GetComponent<scr_gameManager>().globalMovementSpeedGrowth;
            Destroy(other.transform.parent.gameObject);
        }
    }
}
