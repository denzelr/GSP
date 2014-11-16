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
			Debug.Log ("You beat the test level");
			Physics2D.gravity = new Vector2(0f,-9.81f);
			Application.LoadLevel (0);

		}
	}
}
