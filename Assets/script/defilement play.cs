using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class defilementplay : MonoBehaviour
{
    public GameObject musique;
    public AppDat appDatas;
    public float firstgametest = 2;
    public GameObject volumegestion1;
    public GameObject canvasmetrage;
    public GameObject metrage;
    public GameObject canvaspourcent;
    public GameObject metrageanim;
    public GameObject imagefinal;
    public GameObject transifin;
    public GameObject transimort;
    public GameObject decompte;
    public GameObject titre;
    public float timetoaffichemenu;
    public float timetoaffichetuto;
    public GameObject canvas;
    public GameObject canvastuto;
    public GameObject canvascredit;
    public float speed;
    public float speedtuto;
    public bool tutoactivetest;
    public bool creditactivetest;
    public bool playactivetest;
    public bool tutoretouractivetest;
    public bool creditretouractivetest;
    public bool boutonretouractive;
    public bool gruedeadtest = false;
    public bool limittouchetest = false;
    public GameObject boutontuto;
    public GameObject boutoncredit;
    public GameObject boutonplay;
    public GameObject boutontutoretour;
    public GameObject boutoncreditretour;
    public GameObject grue;
    public GameObject titrestatic;
    public GameObject animmortgrue;
    public float i;
    public float o;
    public Vector3 posgrue;
    public Vector3 posmetrage;
    [SerializeField] private Vector3 TargetPos;
    [SerializeField] private Vector3 TutoPos;
    [SerializeField] private Vector3 StartPos;
    // Start is called before the first frame update
    void Awake()
    {
        TargetPos = new Vector2(-120.6f, 0f);
        TutoPos = new Vector2(109.3f, 0f);
        StartPos = new Vector2(88.32f, 0f);
    }

    private void Start()
    {
        
        
        boutonretouractive = false;
        titre.SetActive(true);
        titre.GetComponent<AudioSource>().Play();
        StartCoroutine(affichebouton());

        if (appDatas.firstgame == 1)
        {
            firstgametest = 1;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
        
        posgrue = grue.transform.position;
        posgrue.y = posgrue.y + o;
        gruedeadtest = grue.GetComponent<grue1>().gruedead;
        limittouchetest = grue.GetComponent<grue1>().limittouche;
        
        posmetrage.x = posgrue.x;
        metrage.transform.position = posmetrage;
        

        if(transifin.activeInHierarchy == true )
        {
            imagefinal.SetActive(true);
            StartCoroutine(restmenu());
        }

        if(transimort.activeInHierarchy == true)
        {
            StartCoroutine(affichetransifin1());
        }

        if (limittouchetest == true)
        {
            transimort.transform.position = posgrue;
            animmortgrue.transform.position = posgrue;
            posmetrage.y = posgrue.y + o - 0.3f;
            grue.SetActive(false);
            animmortgrue.SetActive(true);
            canvasmetrage.SetActive(true );
            boutonplay.GetComponent<play>().playactive = false;
            StartCoroutine(affichetransifin());
            canvaspourcent.SetActive(false);
            metrageanim.SetActive(false);
        }
        else
        {
            if (gruedeadtest == true)
            {
                transimort.transform.position = grue.transform.position;
                animmortgrue.transform.position = grue.transform.position;
                posmetrage.y = posgrue.y - 0.3f;
                grue.SetActive(false);
                animmortgrue.SetActive(true);
                canvasmetrage.SetActive(true);
                boutonplay.GetComponent<play>().playactive = false;
                StartCoroutine(affichetransifin());
                canvaspourcent.SetActive(false);
                metrageanim.SetActive(false);
            }
        }



        tutoretouractivetest = boutontutoretour.GetComponent<tutoretour>().tutoretouractive;
        creditretouractivetest = boutoncreditretour.GetComponent<creditretour>().creditretouractive;

        creditactivetest = boutoncredit.GetComponent<credit>().creditactive;
        

        tutoactivetest = boutontuto.GetComponent<tuto>().tutoactive;
        

        playactivetest = boutonplay.GetComponent<play>().playactive;
        i = transform.position.x;

        
        

        if(titre.activeInHierarchy == true && firstgametest == 1)
        {
            
            StartCoroutine(firstgametest1());
        }
        


        if (titre.activeInHierarchy ==true && canvas.activeInHierarchy == false && decompte.activeInHierarchy == false && firstgametest ==0)
        {
            if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                titre.SetActive(false);
                canvas.SetActive(true);
                titrestatic.SetActive(true);

            }
        }

        if(playactivetest == true && this.transform.position.x < 73.53f && this.transform.position.x > 73f)
        {
            metrageanim.SetActive(true);
            canvaspourcent.SetActive(true);
        }

        if ( playactivetest == true)
        {
            tutoretouractivetest = false;
            defilement();
            titre.SetActive (false);
            titrestatic.SetActive (false);
            decompte.SetActive(true);
            canvas.SetActive(false);
            grue.SetActive(true);
            
        }

        if (i == -120.6f)
        {
            boutonplay.GetComponent<play>().playactive = false;
            //playactivetest = false;
            //i = 88.32f;

            SceneManager.LoadScene(0);
        }

        if ( tutoactivetest == true)
        {
            defilementtuto();
            titre.SetActive(false);
            canvas.SetActive(false);
            titrestatic.SetActive(false );
            
            StartCoroutine(affichecanvastuto());
            
        }

        if (creditactivetest == true)
        {
            defilementtuto();
            titre.SetActive(false);
            canvas.SetActive(false);
            titrestatic.SetActive(false);

            StartCoroutine(affichecanvascredit());

        }

        if ( tutoretouractivetest == true )
        {
            
            //tutoretouractivetest = false;
            defilementtutoretour();
            
            boutontuto.GetComponent<tuto>().tutoactive = false;

        }

        if (creditretouractivetest == true)
        {

            //tutoretouractivetest = false;
            defilementtutoretour();

            boutoncredit.GetComponent<credit>().creditactive = false;

        }



        if ( i == 88.32f && tutoretouractivetest == true)
        {
            SceneManager.LoadScene(0);
            //boutontuto.GetComponent<tuto>().tutoactive = false;
            //canvas.SetActive(true);
            //titrestatic.SetActive(true);
            //boutontutoretour.GetComponent<tutoretour>().tutoretouractive = false;
        }

        if (i == 88.32f && creditretouractivetest == true)
        {
            SceneManager.LoadScene(0);
            
        }
    }

    void defilement()
    {
        StartCoroutine(FadeOut(musique.GetComponent<AudioSource>(), 60f));
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,TargetPos,step);

    }

    void defilementtuto()
    {
        float step1 = speedtuto * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, TutoPos, step1);
    }

    void defilementtutoretour()
    {
        StartCoroutine(FadeOut(musique.GetComponent<AudioSource>(), 60f));
        float step2 = speedtuto * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, StartPos, step2);
    }

    

        public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
        {
            float startVolume = audioSource.volume;

            while (audioSource.volume > 0)
            {
                audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

                yield return null;
            }

            audioSource.Stop();
            audioSource.volume = startVolume;
        }

    

    IEnumerator affichebouton()
    {
        yield return new WaitForSeconds(timetoaffichemenu);

        if( canvas.activeInHierarchy == false && playactivetest == false)
        canvas.SetActive(true);
        yield return new WaitForEndOfFrame();
    }

    IEnumerator affichecanvastuto()
    {
        yield return new WaitForSeconds(timetoaffichetuto);
        canvastuto.SetActive(true);
        yield return new WaitForEndOfFrame();
    }

    IEnumerator affichecanvascredit()
    {
        yield return new WaitForSeconds(timetoaffichetuto);
        canvascredit.SetActive(true);
        yield return new WaitForEndOfFrame();
    }

    IEnumerator affichetransifin()
    {
        yield return new WaitForSeconds(0.8f);
        transimort.SetActive(true);
        yield return new WaitForEndOfFrame();
    }

    IEnumerator affichetransifin1()
    {
        yield return new WaitForSeconds(3.2f);
        transifin.SetActive(true);
        transimort.SetActive(false);
        yield return new WaitForEndOfFrame();
    }

    IEnumerator restmenu()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(0);
        yield return new WaitForEndOfFrame();
    }

    IEnumerator firstgametest1()
    {
        yield return new WaitForSeconds(4f);
        firstgametest = 0;
        yield return new WaitForEndOfFrame();
    }
}
