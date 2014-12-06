using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	/** @file trigger */ 
	/// \brief
	/// Trigger: Script used on Trigger to open the door at the end of the level. It turns on the switch lights
	/// and plays audio.
	/// @param movingWall Object to be animated
	/// @param doorOpen Animation to be played
	/// @param success Light to change color above the door.
	/// @param elect1 Light on switch
	/// @param elect2 Light on switch
	/// @param Zap Audio clip to play when door opens.
	///

	Animator anim;
	public GameObject movingWall; //object to be animated
	public string doorOpen;
	public GameObject success;
	public GameObject elect1;
	public GameObject elect2;
	public bool isOpen = false;
	public AudioClip Zap;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.tag == "Finish" && isOpen == false) {
			success.light.color = Color.green;
			audio.PlayOneShot(Zap, 1f);
			elect1.light.intensity = 8;
			elect2.light.intensity = 8;
			isOpen = true;
			movingWall.animation.Play(doorOpen);
			}
	}
	
}
