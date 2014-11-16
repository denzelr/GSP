using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	// Use this for initialization

	Animator anim;
	public GameObject movingWall; //object to be animated
	public string doorOpen;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.tag == "Finish") {
			movingWall.animation.Play(doorOpen);
			}
	}
	
}
