using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_destructable : MonoBehaviour {

    public GameObject activateOnDestroy;

    void OnCollisionEnter(Collision collision)
    {
        activateOnDestroy.transform.parent = null;
        activateOnDestroy.gameObject.SetActive(true);
        Destroy(this.gameObject);
    }
}
