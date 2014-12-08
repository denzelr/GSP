using UnityEngine;
using System.Collections;

public class box : MonoBehaviour {

	/** @file box */ 
	///\brief
	/// box: collision detection for the box. 
	/// @param finish Determines if the box has opened the door yet.
	/// 

	public ParticleSystem ps = null;
	public bool finish = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ParticleSystem.Particle[] particles = new ParticleSystem.Particle[1000];
		int particleCount = ps.GetParticles(particles);
		particleSystem.renderer.sortingLayerName = "Player";

	}

	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.tag == "Finish") {
			Destroy (gameObject);
			
		}
		if (hit.gameObject.tag == "trigger") {
			finish = true;
		}
		if (hit.gameObject.tag == "space") {
			Destroy (gameObject);
			if (finish == false) {
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
