using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {

    public Animator animator = null;
    public Animation myAnimation = null;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    internal void ColidedWithBacteria()
    {
        animator.Play("heart2");
    }
}
