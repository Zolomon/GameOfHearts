using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;
using System.Linq;
using System;

public class Aggressor : MonoBehaviour {
	public Vector3 Direction;
	public float Speed;
	public float maxRadius;
	public float minRadius;
	public event EventHandler test; 

	// Use this for initialization
	void Start () {
		Speed = 4f;
		Direction = new Vector3 ();
		minRadius = 3.0f;
		maxRadius = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		Direction = new Vector3(Input.GetAxis ("Horizontal Protector"), 
		                        Input.GetAxis ("Vertical Protector"), 0);

		Direction.Normalize ();

		var newPosition = currentPosition + Direction * Speed * Time.deltaTime;

		//if (Mathf.Sqrt(newPosition.x*newPosition.x + newPosition.y*newPosition.y) < minRadius) {
		if (newPosition.magnitude < minRadius) {
			newPosition.Normalize();
			newPosition *= minRadius;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (test != null) {
				test(this, EventArgs.Empty);
			}
		}

//		if (newPosition.magnitude > maxRadius) {
//			newPosition.Normalize();
//			newPosition *= maxRadius;
//		}

		transform.localPosition = newPosition;
	}
}
