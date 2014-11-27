using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.tag == "Finish") {
			Destroy (gameObject);
			
		}
	}
}
