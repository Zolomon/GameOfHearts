using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;
using System.Linq;
using System;

public class Aggressor : MonoBehaviour {
	public Vector3 Direction;
	public float Speed;
	public float MaxRadius;
	public float MinRadius;
	public event EventHandler ShootBacteria;
	public float Rotation;

	// Use this for initialization
	void Start () {
		Speed = 4f;
		Direction = new Vector3 ();
		MinRadius = 3.0f;
		MaxRadius = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		Direction = new Vector3(Input.GetAxis ("Horizontal Protector"), 
		                        Input.GetAxis ("Vertical Protector"), 0);

		Direction.Normalize ();

		var newPosition = currentPosition + Direction * Speed * Time.deltaTime;

        //transform.RotateAround (newPosition, Vector3.up, 
        //                        AngleBetween (newPosition, new Vector3 (0, 0, 0)));

		if (newPosition.magnitude < MinRadius) {
			newPosition.Normalize();
			newPosition *= MinRadius;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (ShootBacteria != null) {
				ShootBacteria(this, EventArgs.Empty);
			}
		}

		transform.localPosition = newPosition;
	}

	float AngleBetween(Vector3 lhs, Vector3 rhs) {
		return Mathf.Atan2 (rhs.y - lhs.y, rhs.x - lhs.x);
	}
}
