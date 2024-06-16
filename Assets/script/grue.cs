using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grue : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 velocity;
    public float timeretourgravity;
    public float timenotjump;
    public bool notjump;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        notjump = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && notjump == true)
        {
            notjump = false;
            rb.gravityScale = 0;
            rb.AddForce(velocity * jumpforce);
            StartCoroutine(retourgravity());
            StartCoroutine(notjumptrue());
        }

       
       

    }
    //void MovePlayer(float _verticalMovement)
    //{
    // Vector3 targetVelocity = new Vector2(_verticalMovement, rb.velocity.y);
    //rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .03f);
    //}
    IEnumerator retourgravity()
    {
        yield return new WaitForSeconds(timeretourgravity);
        rb.gravityScale = 1;
        yield return new WaitForEndOfFrame();
    }

    IEnumerator notjumptrue()
    {
        yield return new WaitForSeconds(timeretourgravity + timenotjump);
        notjump = true;
        yield return new WaitForEndOfFrame();
    }


}
