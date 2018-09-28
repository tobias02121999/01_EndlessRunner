using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp_playerspeed : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 8f * Time.deltaTime);
	}
}
