using UnityEngine;
using System.Collections;

/** @file LevelSelect */ 
/// \brief
/// Level select: searches PlayerPrefs for key to unlock levels, if found, it will destroy the lock for the level.
///

public class LevelSelect : MonoBehaviour {
	
	private GameObject lock2;
	private GameObject lock3;
	private GameObject lock4;
	private GameObject lock5;
	private GameObject lock6;
	private GameObject lock7;
	private GameObject lock8;
	private GameObject lock9;
	private GameObject lock10;
	private GameObject lock11;
	private GameObject lock12;
	private GameObject lock13;
	private GameObject lock14;
	private GameObject lock15;
	private GameObject lock16;
	private GameObject lock17;
	private GameObject lock18;
	private GameObject lock19;
	private GameObject lock20;

	static int unlock;
	// Use this for initialization
	void Awake () {
	}
	
	// Update is called once per frame
	void Start () {
		lock2 = GameObject.Find("Lock2");
		lock3 = GameObject.Find("Lock3");
		lock4 = GameObject.Find("Lock4");
		lock5 = GameObject.Find("Lock5");
		lock6 = GameObject.Find("Lock6");
		lock7 = GameObject.Find("Lock7");
		lock8 = GameObject.Find("Lock8");
		lock9 = GameObject.Find("Lock9");
		lock10 = GameObject.Find("Lock10");
		lock11 = GameObject.Find("Lock11");
		lock12 = GameObject.Find("Lock12");
		lock13 = GameObject.Find("Lock13");
		lock14 = GameObject.Find("Lock14");
		lock15 = GameObject.Find("Lock15");
		lock16 = GameObject.Find("Lock16");
		lock17 = GameObject.Find("Lock17");
		lock18 = GameObject.Find("Lock18");
		lock19 = GameObject.Find("Lock19");
		lock20 = GameObject.Find("Lock20");

		if(PlayerPrefs.HasKey("Level2")){
			Destroy(lock2);
		}
		if(PlayerPrefs.HasKey("Level3")){
			Destroy(lock3);
		}
		if(PlayerPrefs.HasKey("Level4")){
			Destroy(lock4);
		}
		if(PlayerPrefs.HasKey("Level5")){
			Destroy(lock5);
		}
		if(PlayerPrefs.HasKey("Level6")){
			Destroy(lock6);
		}
		if(PlayerPrefs.HasKey("Level7")){
			Destroy(lock7);
		}
		if(PlayerPrefs.HasKey("Level8")){
			Destroy(lock8);
		}
		if(PlayerPrefs.HasKey("Level9")){
			Destroy(lock9);
		}
		if(PlayerPrefs.HasKey("Level10")){
			Destroy(lock10);
		}
		if(PlayerPrefs.HasKey("Level11")){
			Destroy(lock11);
		}
		if(PlayerPrefs.HasKey("Level12")){
			Destroy(lock12);
		}
		if(PlayerPrefs.HasKey("Level13")){
			Destroy(lock13);
		}
		if(PlayerPrefs.HasKey("Level14")){
			Destroy(lock14);
		}
		if(PlayerPrefs.HasKey("Level15")){
			Destroy(lock15);
		}
		if(PlayerPrefs.HasKey("Level16")){
			Destroy(lock16);
		}
		if(PlayerPrefs.HasKey("Level17")){
			Destroy(lock17);
		}
		if(PlayerPrefs.HasKey("Level18")){
			Destroy(lock18);
		}
		if(PlayerPrefs.HasKey("Level19")){
			Destroy(lock19);
		}
		if(PlayerPrefs.HasKey("Level20")){
			Destroy(lock20);
		}

	}

}
