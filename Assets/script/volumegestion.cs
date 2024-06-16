using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class volumegestion : MonoBehaviour
{
    public AppDat appDatas;
    public GameObject boutonoff;
    public float firstgame;
    public GameObject bouton50;
    public GameObject bouton75;
    public GameObject bouton100;
    public GameObject bouton50off;
    public GameObject bouton75off;
    public GameObject bouton100off;
    // Start is called before the first frame update
    private void Awake()
    {
        //PlayerPrefs.GetFloat("volume", appDatas.volume);
        //PlayerPrefs.GetFloat("volumeon", appDatas.volumeon);
        //PlayerPrefs.GetFloat("firsttime", firstgame);
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (appDatas.firstgame == 0)
        {
            if (boutonoff.activeInHierarchy == true)
            {
                AudioListener.volume = 0;
               
            }
            else
            {

                AudioListener.volume = appDatas.volume;
            }
            
            
        }
        else if (appDatas.firstgame == 1)
        {
            bouton100.SetActive(true);
            bouton50.SetActive(true);
            bouton75.SetActive(true);
            bouton100off.SetActive(false);
            bouton50off.SetActive(false);
            bouton75off.SetActive(false);
            appDatas.firstgame = 0;
            //PlayerPrefs.SetFloat("firstgame", 0);
            
        }
        
    }
}
