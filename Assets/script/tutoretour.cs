using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutoretour : MonoBehaviour
{
    public bool tutoretouractive = false;
    public GameObject boutontuto;
    public GameObject fond;
    public GameObject titre;
    public GameObject tuto1;
    public GameObject tuto2;
    public GameObject text1;
    public GameObject text2;
    public GameObject tfondtext;
    

    public void Tutoretour()
    {
        tutoretouractive = true;
        boutontuto.SetActive(false);
        fond.SetActive(false);
        titre.SetActive(false);
        tuto1.SetActive(false);
        tuto2.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        tfondtext.SetActive(false);
        
        
    }
}
