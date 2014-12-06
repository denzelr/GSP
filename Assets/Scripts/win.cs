using UnityEngine;
using System.Collections;

/** @file win */ 

public class win : MonoBehaviour {


	/// \brief
	/// win: Detects if player collides with collider at the end of the level, then passes a key to
	/// PlayerPrefs and loads next level.
	/// 
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.tag == "Player") {
			PlayerPrefs.SetString("Level" + (Application.loadedLevel), "Gravity");
			//PlayerPrefs.SetInt("Unlock",unlock);
			Application.LoadLevel (Application.loadedLevel + 1);

		}
	}
}
