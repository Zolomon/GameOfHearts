using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeartScript : MonoBehaviour {

	private float timeBetweenBeats = 1.0f;
	private float timerToBeat = 0.0f;
    public GameObject blood;

	bool playingBeatAnimation = false;

	public Animator anim = null;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		CountdownToBeat();
	}

	void CountdownToBeat ()
	{
		if ( !playingBeatAnimation )
		{
			timerToBeat += Time.deltaTime;
			if ( timerToBeat > timeBetweenBeats )
			{
				anim.SetInteger("State", 1);
				playingBeatAnimation = true;
				timerToBeat = 0.0f;
			}
		}

        if( anim.speed > 10)
        {
            blood.SetActive(true);
            Destroy(gameObject);
        }
	}

    internal void ColidedWithBacteria()
    {
		if ( timeBetweenBeats > 0.0f )
		{
			timeBetweenBeats -= 0.1f;
		}

		anim.speed += 0.1f;
	}

	internal void DoneBeating()
	{
		anim.SetInteger("State", 0);
		playingBeatAnimation = false;
	}
}
