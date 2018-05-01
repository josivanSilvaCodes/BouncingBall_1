using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour 
{
    Rigidbody2D rb2D;
    float forceMax = 1000;
    float forceX = 1000;
    float forceY = 1000;

    void Start () 
    {	rb2D = GetComponent<Rigidbody2D>();   }

    void Update () 
    {
        rb2D.AddForce(new Vector3(forceX*Time.deltaTime, forceY*Time.deltaTime, 0)); 

        if (forceX >= forceMax)  {forceX = forceMax; }
        if (forceX <= -forceMax) {forceX = -forceMax;}
        if (forceY >= forceMax)  {forceY = forceMax; }
        if (forceY <= -forceMax) {forceY = -forceMax;}
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "barX")
        {
            rb2D.velocity = new Vector2(0,0);
            forceX = -forceX;
        }

        if (col.gameObject.tag == "barY")
        {
            rb2D.velocity = new Vector2(0,0);
            forceY = -forceY;
        }
    }
}
