using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour {

	public bool GameStarted = false;
	public GameObject leftChest = null;
	public GameObject rightChest = null;
	public GameObject text = null;

    private float speed = 2.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.F1) )
		{
			GameStarted = true;
		}

        if (GameStarted)
        {
            leftChest.transform.position += new Vector3(-Time.deltaTime * speed, 0f, 0f);
            rightChest.transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
            text.transform.position += new Vector3(0, Time.deltaTime * speed, 0);
        }
	}
}
