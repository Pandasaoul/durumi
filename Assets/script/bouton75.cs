using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bouton75 : MonoBehaviour
{
    public GameObject boutonpasactif;
    public GameObject bouton100;
    public GameObject bouton100off;

    public void barrevolume()
    {
        if (bouton100.activeInHierarchy == true)
        {
            bouton100.SetActive(false);
            bouton100off.SetActive(true);

        }
    }
}
