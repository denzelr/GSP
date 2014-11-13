using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.tag == "Player") {
			Time.timeScale = 0;
			Debug.Log ("You beat the test level");
		}
	}
}
