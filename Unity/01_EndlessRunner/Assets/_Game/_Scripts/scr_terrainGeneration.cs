using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_terrainGeneration : MonoBehaviour {

    //reference
    //public GameObject terrainPrefab;
    public Transform spawnTerrainLoc;
    public GameObject[] chunks;
    public BoxCollider generationTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Instantiate(chunks[Random.Range(0, chunks.Length)], spawnTerrainLoc.position, Quaternion.identity);
            generationTrigger.enabled = !generationTrigger.enabled;
            //terrainPrefab = Instantiate(terrainPrefab, spawnTerrainLoc.position, Quaternion.identity);
            //terrainPrefab.transform.parent = null;
        }

    }

}
