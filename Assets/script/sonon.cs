using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonon : MonoBehaviour
{
    public AppDat volumeinfo;
    public GameObject boutonmute;
    public void sonon1()
    {
        volumeinfo.volumeon = 0;
        this.gameObject.SetActive(false);
        boutonmute.SetActive(true);
    }
}
