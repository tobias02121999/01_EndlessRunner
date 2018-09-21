using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_terrainGeneration : MonoBehaviour {

    //reference
    public GameObject terrainPrefab;
    public Transform spawnTerrainLoc;

    private void OnTriggerEnter(Collider other)
    {
        terrainPrefab = Instantiate(terrainPrefab, spawnTerrainLoc.position, Quaternion.identity);
    }

}
