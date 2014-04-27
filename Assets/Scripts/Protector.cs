using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Protector : MonoBehaviour {
	public Vector3 Direction;
	public float Speed;
	public float maxRadius;

	// Use this for initialization
	void Start () {
		Speed = 4f;
		Direction = new Vector3 ();
		maxRadius = 3.0f;
	}

	void Update () {
		Vector3 currentPosition = transform.position;
		Direction = new Vector3(Input.GetAxis ("Horizontal Aggressor"), 
		                        Input.GetAxis ("Vertical Aggressor"), 0);

		Direction.Normalize ();

		var newPosition = currentPosition + Direction * Speed * Time.deltaTime;

		if (newPosition.magnitude > maxRadius) {
			newPosition.Normalize();
			newPosition *= maxRadius;
		}
		
		transform.localPosition = newPosition;
		KillBacteria ();
	}

	void KillBacteria(){
		if (Input.GetKeyDown(KeyCode.Z)) {
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("bacteria")) {
				if(Vector3.Distance(go.transform.position,this.transform.position) < 0.75)
				{
					Destroy(go);
				}
			}		
		}
	}
}