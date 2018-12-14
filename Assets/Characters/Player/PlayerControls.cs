using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : Character 
{
	// Update is called once per frame
	public override void Update () 
	{
		base.Update ();

		if (Input.GetKey ("w")) 
		{
			if (grounded) 
			{
				Jump (0.0f, 5);
			}
		}


		if (Input.GetKey ("s")) 
		{
		}


		if (Input.GetKey ("a")) 
		{
			if (grounded) 
			{
				acc.x = acc.x - grdMve;
			} 
			else 
			{
				acc.x = acc.x - airMve;
			}
		}

		if (Input.GetKey ("d")) 
		{
			if (grounded) 
			{
				acc.x = acc.x + grdMve;
			} 
			else 
			{
				acc.x = acc.x + airMve;
			}
		}


		vel = vel + acc;

		gameObject.transform.Translate (vel);

		vel.x = vel.x * slippery;

		if (vel.x < 0.1f) 
		{
			StopCharacter (0);
		}

		if (vel.y < 0.1f) 
		{
			StopCharacter (1);
		}
		acc = new Vector2();
	}
}
