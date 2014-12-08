using UnityEngine;
using System.Collections;

public class gravityShift : MonoBehaviour {

	//float gravity = -9.8f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.I)) {
			Physics2D.gravity = new Vector2(0f,9.81f);

		}
		if (Input.GetKeyDown(KeyCode.K)) {
			Physics2D.gravity = new Vector2(0f,-9.81f);

		}
		if (Input.GetKeyDown(KeyCode.J)) {
			Physics2D.gravity = new Vector2(-9.81f,0f);

		}
		if (Input.GetKeyDown(KeyCode.L)) {
			Physics2D.gravity = new Vector2(9.81f,0f);

		}
	}
	
}
