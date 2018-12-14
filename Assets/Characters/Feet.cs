using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Feet : MonoBehaviour {
		// Use this for initialization
	void Start () {
		if (!transform.parent.gameObject.GetComponent<Character> ()) 
		{
			transform.parent.gameObject.AddComponent<Character> ();

			Debug.LogError ("Parent does not conatin Character Type class");
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log ("hit");
		if (col.gameObject.tag == "ground") 
		{
			GetComponentInParent <Character>().grounded = true;
		}
	}

	}
