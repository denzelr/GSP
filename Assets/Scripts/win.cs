using UnityEngine;
using System.Collections;

public class win : MonoBehaviour {


	//static int unlock;
	// Use this for initialization
	//void Awake () {
	//	unlock = PlayerPrefs.GetInt("Unlock",0);
	//}
	
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
