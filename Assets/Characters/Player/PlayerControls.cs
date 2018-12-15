using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : Character 
{
	public float gravityScale;
	void Start ()
	{
		gravityScale = gameObject.GetComponent<Rigidbody2D> ().gravityScale;
	}

	// Update is called once per frame
	public override void Update () 
	{

		base.Update ();

		if (Input.GetKey ("w")) 
		{
			if (grounded) 
			{
				Jump (0.0f, jumpSpeed);
			}
		}


		if (Input.GetKey ("s")) 
		{
		}


		if (Input.GetKey ("a")) 
		{
			if (grounded) 
			{
				acc.x = -grdMve;
			} 
			else 
			{
				acc.x = -airMve;
			}
		}

		if (Input.GetKey ("d")) 
		{
			if (grounded) 
			{
				acc.x = grdMve;
			} 
			else 
			{
				acc.x = airMve;
			}
		}

		if (!grounded) 
		{

			gameObject.GetComponent<Rigidbody2D> ().gravityScale = gravityScale
				+ gameObject.GetComponent<Rigidbody2D> ().gravityScale;
		}

		gameObject.GetComponent<Rigidbody2D> ().velocity = vel + acc;

		gameObject.transform.Translate (vel);



		vel = vel * slippery;

		if (vel.x < 0.1f) 
		{
			StopCharacter (0);
		}

		if (grounded) 
		{
			StopCharacter (1);
		}
	}

	void OnCollisionStay2D (Collision2D col)
	{
		gameObject.GetComponent<Rigidbody2D> ().gravityScale = 
			gravityScale;
		if (col.gameObject.tag == "ground") 
		{
			grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == "ground") 
		{
			grounded = false;
		}
	}
}
