using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bouton50 : MonoBehaviour
{
    public GameObject boutonpasactif;
    public GameObject bouton75;
    public GameObject bouton75off;
    public GameObject bouton100;
    public GameObject bouton100off;
    public void barrevolume()
    {
        if(bouton75.activeInHierarchy == true)
        {

            bouton75.SetActive(false);
            bouton75off.SetActive(true);
            bouton100.SetActive(false);
            bouton100off.SetActive(true);
        }
        
        
        
    }
}
