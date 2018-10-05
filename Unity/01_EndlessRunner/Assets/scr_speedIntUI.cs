using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_speedIntUI : MonoBehaviour {

    //Reference
    private scr_gameManager gameManager;
    public Transform player;

    public Text speedText;
    public Text distanceText;
     
    // Use this for initialization
	void Start () {
        gameManager = GameObject.FindObjectOfType<scr_gameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        speedText.text = (gameManager.globalMovementSpeed*100).ToString();
        distanceText.text = player.position.z.ToString("0");
	}
}
