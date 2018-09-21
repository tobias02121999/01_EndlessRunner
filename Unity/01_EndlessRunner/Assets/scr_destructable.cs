using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_destructable : MonoBehaviour {

    public GameObject rocks;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        rocks.transform.parent = null;
        rocks.gameObject.SetActive(true);
        Destroy(this.gameObject);
    }
}
