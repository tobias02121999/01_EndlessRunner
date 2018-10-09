using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_distanceIntUI : MonoBehaviour
{

    //Reference
    private scr_gameManager gameManager;
    public Transform player;
    public Text distanceText;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<scr_gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceText.text = player.position.z.ToString("0");
    }
}
