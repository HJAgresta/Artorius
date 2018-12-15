using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
	
	public Vector2 acc = new Vector2(0.0f,0.0f);
	public Vector2 vel = new Vector2(0.0f,0.0f);
	public bool grounded = false;
	public float fallAcc;

	public float grdMve = 0.5f;
	public float airMve = 0.1f;
	public float slippery = 0.5f;
	public float jumpSpeed = 2f;

	protected void Jump(float delay, float upVelocity)
	{
		acc.y = upVelocity;
	}

	public virtual void Update()
	{

		acc = new Vector2 ();
	}

	/// <summary>
	/// Stops the character.
	/// </summary>
	/// <param name="dir">Direction to stop character in. 0=X,1=Y,2=X&Y</param>
	protected void StopCharacter(int dir){
		if (dir == 0) 
		{
			vel.x = 0.0f;
		} 
		else if (dir == 1) 
		{
			vel.y = 0.0f;
		} 
		else if (dir == 2) 
		{
			vel.Set (0.0f, 0.0f);
		}
	}
}
