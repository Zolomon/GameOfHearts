using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;
using System.Linq;

public class Protector : MonoBehaviour {
	public Vector3 Direction { get; set; }
	public float Speed { get; set; }
	private int xDir { get; set; }
	private int yDir { get;set; }

	private List<KeyCode> keys {get;set;}

	// Use this for initialization
	void Start () {
		Speed = 1f;
		Direction = new Vector3 ();
		keys = new List<KeyCode> {KeyCode.A, KeyCode.W, KeyCode.S, KeyCode.D};
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;

		Direction.Set(UnityEngine.Input.GetAxis("Horizontal"),
		              UnityEngine.Input.GetAxis("Vertical"), 0);
		Direction = transform.TransformDirection(Direction);

//		xDir = 0;
//		yDir = 0;
//
//		if (Input.GetKey(KeyCode.W)) {
//			yDir = 1;
//		} 
//		if (Input.GetKey(KeyCode.S)) {
//			yDir = -1;
//		}
//
//		if (Input.GetKey(KeyCode.A)) {
//			xDir = -1;
//		} 
//		if (Input.GetKey(KeyCode.D)) {
//			xDir = 1;
//		}

		//Direction = new Vector3 (xDir, yDir, 0);

		//Direction.Normalize ();

		transform.localPosition = currentPosition + Direction * Speed * Time.deltaTime;
	}
}
