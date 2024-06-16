using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bouton50off : MonoBehaviour
{
    public AppDat appDatas;
    public GameObject boutonactif;
    public GameObject boutonavant;
    
    
    public void barrevolume()
    {
        if(boutonavant.activeInHierarchy == true)
        {
            this.gameObject.SetActive(false);
            boutonactif.SetActive(true);
        }
       


    }
}
