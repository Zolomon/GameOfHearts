using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;
using System.Linq;

public class Protector : MonoBehaviour {
	public Vector3 Direction { get; set; }
	public float Speed { get; set; }

	// Use this for initialization
	void Start () {
		Speed = 4f;
		Direction = new Vector3 ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		Direction = new Vector3(Input.GetAxis ("Horizontal Protector"), Input.GetAxis ("Vertical Protector"), 0);

		Direction.Normalize ();

		transform.localPosition = currentPosition + Direction * Speed * Time.deltaTime;
	}
}
