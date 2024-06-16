using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exit : MonoBehaviour
{
    public AppDat appDatas;
    public void exit1()
    {

       
        appDatas.volumeon = 1;
        appDatas.volume = 1;
        appDatas.firstgame = 1;
        
        Application.Quit();
    }
}
