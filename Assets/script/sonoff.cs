using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonoff : MonoBehaviour
{
    public AppDat appDatas;
    public GameObject boutonon;
    public GameObject bouton100;
    public GameObject bouton100off;
    public GameObject bouton75;
    public GameObject bouton75off;
    public GameObject bouton50;
    public GameObject bouton50off;
    public GameObject bouton25;
    public void sonoff1()
    {
        appDatas.volumeon = 1;
        this.gameObject.SetActive(false);
        boutonon.SetActive(true);

        if (appDatas.volume == 1)
        {
            bouton100.SetActive(true);
            bouton75.SetActive(true);
            bouton50.SetActive(true);
            bouton25.SetActive(true);
        }
        else if (appDatas.volume == 0.50f)
        {
            bouton100off.SetActive(true);
            bouton75.SetActive(true);
            bouton50.SetActive(true);
            bouton25.SetActive(true);
        }
        else if (appDatas.volume == 0.25f)
        {
            bouton100off.SetActive(true);
            bouton75off.SetActive(true);
            bouton50.SetActive(true);
            bouton25.SetActive(true);
        }
        else if (appDatas.volume == 0.10f)
        {
            bouton100off.SetActive(true);
            bouton75off.SetActive(true);
            bouton50off.SetActive(true);
            bouton25.SetActive(true);
        }
    }
}
