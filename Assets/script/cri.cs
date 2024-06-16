using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cri : MonoBehaviour
{
    public bool acrie;
    public AudioClip gruecri;
    public float timetofirstcri;
    public bool coroutencours;
    public int random1;
    public GameObject criempty;
    public int int1;
    // Start is called before the first frame update
    void Start()
    {
        coroutencours = false;
        acrie = false;
        criempty.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (criempty.activeInHierarchy == false)
        {
            
            StartCoroutine(cri1());
            StartCoroutine(finducri());
        }

        

    }
    

    




    IEnumerator cri1()
    {

        yield return new WaitForSeconds(timetofirstcri);
        //gameObject.GetComponent<AudioSource>().PlayOneShot(gruecri);
        criempty.SetActive(true);

        yield return new WaitForEndOfFrame();
    }


    IEnumerator finducri()
    {
        yield return new WaitForSeconds(timetofirstcri + 8);
        criempty.SetActive(false);
        yield return new WaitForEndOfFrame();

    }
}

    

