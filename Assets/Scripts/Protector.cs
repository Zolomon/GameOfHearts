using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class Protector : MonoBehaviour {
	public Vector3 Direction { get; set; }
	public float Speed { get; set; }
	private int xDir { get; set; }
	private int yDir { get;set; }

	// Use this for initialization
	void Start () {
		Speed = 1f;
		Direction = new Vector3 ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;

		if (Input.GetKeyDown(KeyCode.W)) {
			yDir = 1;
		}

		if (Input.GetKeyDown(KeyCode.S)) {
			yDir = -1;
		}

		if (Input.GetKeyDown(KeyCode.A)) {
			xDir = -1;
		}

		if (Input.GetKeyDown(KeyCode.D)) {
			xDir = 1;
		}

		Direction = new Vector3 (xDir, yDir, 0);

		Direction.Normalize ();

		transform.localPosition = currentPosition + Direction * Speed * Time.deltaTime;
	}
}
