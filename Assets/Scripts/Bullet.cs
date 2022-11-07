using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; // speed of the shot.
    public Rigidbody2D rb; //the body of the object

        void Start(){
        rb.velocity =  transform.right * speed; // the bullet goes with the character to the right.
    }
    

}