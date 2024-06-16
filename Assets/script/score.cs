using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text scoreText;
    public Text metragegrue;
    public GameObject bg;
    public float bgpos;
    public float posstartscore;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bg.transform.position.x >= 0)
        {
            bgpos = bg.transform.position.x - posstartscore;
        }
        else
        {
            bgpos = Math.Abs(posstartscore) + Math.Abs(bg.transform.position.x);
        }
        
        scoreText.text = Math.Abs( Math.Truncate( Math.Truncate(bgpos * 5.9)/10)) + "%";
        metragegrue.text = Math.Abs(Math.Truncate(bgpos * 5.9)) + "m";

    }
}
