using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Protector : MonoBehaviour {
	public Vector3 Direction;
	public float Speed;
	public float maxRadius;
    public GameStarter game;
	// Use this for initialization
	void Start () {
		Speed = 4f;
		Direction = new Vector3 ();
		maxRadius = 3.0f;
	}

	void Update () {
        if (!game.GameStarted) return;

		Vector3 currentPosition = transform.position;
		Direction = new Vector3(Input.GetAxis ("Horizontal Protector"), 
		                        Input.GetAxis ("Vertical Protector"), 0);

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
		if (Input.GetKeyDown(KeyCode.Space)) {
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("bacteria")) {
				if(Vector3.Distance(go.transform.position,this.transform.position) < 0.75)
				{
					Destroy(go);
				}
			}		
		}
	}
}