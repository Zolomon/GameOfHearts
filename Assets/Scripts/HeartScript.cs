using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {

    public Animator animator = null;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    internal void ColidedWithBacteria()
    {
        var animState = animator.GetCurrentAnimationClipState(LayerMask.NameToLayer("Default"));
        var clip = animState[0];
        

    }
}
