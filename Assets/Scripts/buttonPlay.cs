using UnityEngine;
using System.Collections;

public class buttonPlay : MonoBehaviour {

	public GameObject Play;
	public GameObject Levels;
	public GameObject Credits;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if (gameObject.name == "Play") {
				Application.LoadLevel (1);
		}
		if (gameObject.name == "Levels") {
			Application.LoadLevel (1);
		}
		if (gameObject.name == "Credits") {
			Application.LoadLevel (1);
		}
	}
}
