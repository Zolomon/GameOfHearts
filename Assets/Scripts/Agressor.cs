using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Agressor : MonoBehaviour {
	public Vector3 Direction {get;set;}
	public float Speed {get;set;}

	// Use this for initialization
	void Start () {
		Speed = 4f;
		Direction = new Vector3 ();
	}

	void Update () {
		Vector3 currentPosition = transform.position;
		Direction = new Vector3(Input.GetAxis ("Horizontal Aggressor"), Input.GetAxis ("Vertical Aggressor"), 0);

		Direction.Normalize ();
		
		transform.localPosition = currentPosition + Direction * Speed * Time.deltaTime;
	}
}
