using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bouton75off : MonoBehaviour
{
    public AppDat appDatas;
    public GameObject boutonactif;
    public GameObject boutonavant;
    public GameObject boutonavantoff;
    
    public void barrevolume()
    {
        if(boutonavant.activeInHierarchy == true)
        {
            this.gameObject.SetActive(false);
            boutonactif.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
            boutonactif.SetActive(true);
            boutonavant.SetActive(true);
            boutonavantoff.SetActive(false);
            
        }


    }
}
