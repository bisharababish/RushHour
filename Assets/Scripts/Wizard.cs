using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour {

	private Rigidbody2D rb; // body of the character.
	private Animator anim; //animtionof the character.
	private float dirX, moveSpeed; //direction X and the movespeed.
	private bool facingRight = true; //facing right and left of the characters.
	private Vector3 localScale; 


	// Use this for initialization
	void Start () {
	rb = GetComponent<Rigidbody2D> (); //takes the body component of the character.
		anim = GetComponent<Animator> (); //takes the animtion component of the character.
		localScale = transform.localScale* 3f; //transforming the localstate of the charcter to left and right.
		moveSpeed = 5f; //declaring the speed as 5 Float.

    }
	
	// Update is called once per frame
	void Update () {		
		dirX = Input.GetAxisRaw ("Horizontal") * moveSpeed; // moves right and left.

		if (Input.GetButtonDown ("Jump") && rb.velocity.y == 0)
			rb.AddForce (Vector2.up * 700F); //  makes the chrcter jump of 700 Float.
        //logic for running,jumping,Falling.
		if (Mathf.Abs(dirX) > 0 && rb.velocity.y == 0 )
		 anim.SetBool ("isRunning", true);
		 else 		 
		 anim.SetBool ("isRunning", false);

		 if (rb.velocity.y == 0) {
			anim.SetBool ("isJumping", false);
			anim.SetBool ("isFalling", false);
		}

		 if (rb.velocity.y > 0)
			anim.SetBool ("isJumping", true);
		
		if (rb.velocity.y < 0) {
			anim.SetBool ("isJumping", false);
			anim.SetBool ("isFalling", true );
		}
		Attack();
	}

	void FixedUpdate()
	{
	rb.velocity = new Vector2 (dirX, rb.velocity.y);
	}


	void LateUpdate()
	{
		if (dirX > 0)// changing the character face to the right else to the left.
			facingRight = true;
		else if (dirX < 0)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;

	}
	void Attack(){
		if ( Input.GetButtonDown("Fire1")) // using the right click of the mouse which is clled "Fire1"
        // which makes the attack animation true else false.
		{
			anim.SetBool("isAttacking", true );
		}
		if ( Input.GetButtonUp("Fire1"))
		{
		anim.SetBool("isAttacking", false );
		}

	}


}