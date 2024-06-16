using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bouton25 : MonoBehaviour
{
    
    public GameObject bouton50;
    public GameObject bouton50off;
    public GameObject bouton75;
    public GameObject bouton75off;
    public GameObject bouton100;
    public GameObject bouton100off;
    public void barrevolume()
    {
        if(bouton50.activeInHierarchy == true)
        {
            bouton50.SetActive(false);
            bouton50off.SetActive(true);
            bouton75.SetActive(false);
            bouton75off.SetActive(true);
            bouton100.SetActive(false);
            bouton100off.SetActive(true);
        }
        
        
        
    }
}
