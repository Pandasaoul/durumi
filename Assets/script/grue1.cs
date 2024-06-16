using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class grue1 : MonoBehaviour
{
    public AudioClip vole;
    public GameObject canvasmetrage;
    public GameObject animmetrage;
    public float velocity = 2.4f;
    public Rigidbody2D rigidbody1;
    public Animator animator;
    public bool peutpress;
    public float timetopeutpress;
    public float timeanimstart;
    public GameObject boutonplay;
    public bool playable;
    public float speedgrueanim;
    public float speedgrueanimfin;
    public bool grueenplace;
    public bool fin;
    public bool fadeout;
    public bool gruedead;
    public bool limittouche;
    public float fadespeed;
    public float o;
    public GameObject bg;
    public GameObject collidermontagne;
    [SerializeField] private Vector3 grueplaypos;
    [SerializeField] private Vector3 grueposfin;

    // Start is called before the first frame update
    void Start()
    {
        limittouche = false;
        gruedead = false;
        fin = false;
        grueenplace = false;
        grueplaypos = new Vector2(-5.2f, 0f);
        grueposfin = new Vector3(6.15f, 7.3f, 0f);
        rigidbody1 = GetComponent<Rigidbody2D>();
        rigidbody1.gravityScale = 0;
        playable = boutonplay.GetComponent<play>().playactive;
        StartCoroutine(timeanimstart1());
    }

    // Update is called once per frame
    void Update()
    {      
        

        if ( fin == true )
        {
            canvasmetrage.SetActive(false);
            animmetrage.SetActive(false);
            peutpress = false;
            bg.GetComponent<Collider2D>().enabled = false;
            collidermontagne.SetActive(false);
            
            animator.SetBool("fin", true);

            Vector3 dir = grueposfin - transform.position;
            transform.Translate(dir.normalized * speedgrueanimfin * Time.deltaTime, Space.World);
            fadeout = true;

                //defilementgruefin();
        }

        if(fadeout == true )
        {
            Color objectColor = this.GetComponent<Renderer>().material.color;
            float fadeAmont = objectColor.a - (fadespeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmont);
            this.GetComponent<Renderer>().material.color = objectColor;

            if(objectColor.a <= 0 )
            {
              
                gameObject.SetActive(false);
            }
        }

        if (transform.position == grueplaypos)
        {
            grueenplace = true;
            animator.SetBool("fin", false);
        }

        if (playable == true && grueenplace == false && fin == false)
        {
            animator.SetBool("fin", true);
            defilementgrue();
            StartCoroutine(timeanimstart1());
        }

        if (Input.GetKeyDown(KeyCode.Space) && peutpress)
        {
            peutpress = false;
            animator.SetBool("spacepress", true);
            GetComponent<AudioSource>().PlayOneShot(vole);
            rigidbody1.velocity = Vector2.up * velocity;
            StartCoroutine(peutpresstrue());
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("fin"))
        {
            fin = true;
            rigidbody1.gravityScale = -0.1f;

        }
        else
        {
            if (col.CompareTag("montagne"))
            {
                gruedead = true;
            }
            else
            {
                if (col.CompareTag("limit"))
                {
                    gruedead = true;
                    limittouche = true;
                }
            }
        }
        
    }

    

    //private void OnTriggerExit2D(Collider2D collision)
    //{
        //if(collision.CompareTag("limit"))
        //{ 
            //gruedead = true;
            //limittouche = true;
        //}
    //}
    



    void defilementgrue()
    {
        float step = speedgrueanim * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, grueplaypos, step);

    }

    void defilementgruefin()
    {
        float step1 = speedgrueanimfin * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, grueposfin, step1);

    }
    IEnumerator peutpresstrue()
    {
        yield return new WaitForSeconds(timetopeutpress);
        peutpress = true;
        animator.SetBool("spacepress", false);
        yield return new WaitForEndOfFrame();
    }

    IEnumerator timeanimstart1()
    {
        yield return new WaitForSeconds(timeanimstart);
        
        rigidbody1.gravityScale = 1;
        peutpress = true;
        yield return new WaitForEndOfFrame();
    }
}

