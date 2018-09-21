using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_terrainMovement : MonoBehaviour {

    //Reference

    public float terrainMovSpeed;

    private void Start()
    {
        terrainMovSpeed = 8f;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * -terrainMovSpeed * Time.deltaTime);
    }

}
