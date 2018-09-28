using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_rowController : MonoBehaviour {

    public GameObject gameManager;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.forward * gameManager.GetComponent<scr_gameManager>().globalMovementSpeed;
	}
}
