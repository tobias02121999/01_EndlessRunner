using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_rowController : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.forward * speed;
	}
}
