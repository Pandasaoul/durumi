using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditretour : MonoBehaviour
{
    public bool creditretouractive = false;
    public GameObject boutoncredit;
    public GameObject imagecredit;


    public void creditretour1()
    {
        creditretouractive = true;
        boutoncredit.SetActive(false);
        imagecredit.SetActive(false);


    }
}
