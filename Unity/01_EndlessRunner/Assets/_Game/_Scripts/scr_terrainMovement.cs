using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_terrainMovement : MonoBehaviour {

    [SerializeField]
    private float terrainMovSpeed;

    private void Start()
    {
        terrainMovSpeed = -5f;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * terrainMovSpeed * Time.deltaTime);
    }

}
