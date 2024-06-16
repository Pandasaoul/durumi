using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class volume : MonoBehaviour
{
    public GameObject boutonon;
    public GameObject boutonmute;
    public GameObject bouton25;
    public GameObject bouton50;
    public GameObject bouton75;
    public GameObject bouton100;
    public GameObject boutonoff50;
    public GameObject boutonoff75;
    public GameObject boutonoff100;
    public AppDat volumeinfo;
    // Start is called before the first frame update
    void Start()
    {

        if (volumeinfo.volumeon == 1)
        {
            boutonon.SetActive(true);
            boutonmute.SetActive(false);
        }
        else
        {
            boutonon.SetActive(false);
            boutonmute.SetActive(true);
        }

        if (volumeinfo.volume == 0.10f)
        {
            bouton25.SetActive(true);
            bouton50.SetActive(false);
            boutonoff50.SetActive(true);
            bouton75.SetActive(false);
            boutonoff75.SetActive(true);
            bouton100.SetActive(false);
            boutonoff100.SetActive(true);
        }
        if (volumeinfo.volume == 0.25f)
        {
            bouton25.SetActive(true);
            bouton50.SetActive(true);
            boutonoff50.SetActive(false);
            bouton75.SetActive(false);
            boutonoff75.SetActive(true);
            bouton100.SetActive(false);
            boutonoff100.SetActive(true);
        }
        if (volumeinfo.volume == 0.50f)
        {
            bouton25.SetActive(true);
            bouton50.SetActive(true);
            boutonoff50.SetActive(false);
            bouton75.SetActive(true);
            boutonoff75.SetActive(false);
            bouton100.SetActive(false);
            boutonoff100.SetActive(true);
        }
        if (volumeinfo.volume == 1f)
        {
            bouton25.SetActive(true);
            bouton50.SetActive(true);
            boutonoff50.SetActive(false);
            bouton75.SetActive(true);
            boutonoff75.SetActive(false);
            bouton100.SetActive(true);
            boutonoff100.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (volumeinfo.volumeon == 1)
        {
            if (bouton100.activeInHierarchy == true)
            {
                volumeinfo.volume = 1f;
                
            }
            else if (bouton75.activeInHierarchy == true)
            {
                volumeinfo.volume = 0.50f;
                
            }
            else if (bouton50.activeInHierarchy == true)
            {
                volumeinfo.volume = 0.25f;
                
            }
            else if (bouton25.activeInHierarchy == true)
            {
                volumeinfo.volume = 0.10f;
                
            }
        }

        if(volumeinfo.volumeon == 0)
        {
            
            bouton25.SetActive(false);
            bouton50.SetActive(false);
            bouton75.SetActive(false);
            bouton100.SetActive(false);
            boutonoff50.SetActive(false);
            boutonoff75.SetActive(false);
            boutonoff100.SetActive(false);
        }
        
    }
}
