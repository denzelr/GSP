using UnityEngine;
using System.Collections;

/** @file UIManager */ 
/// \brief
/// UI Manager: Creates functions to be called when a button is clicked in the main menu.
/// 

public class UIManager : MonoBehaviour {

	public void StartGame(){
		Application.LoadLevel (2);
	}
	public void Levels() {
		Application.LoadLevel (1);
	}
	public void Credits() {
		Application.LoadLevel (22);
	}
	public void TitleMenu() {
		Application.LoadLevel (0);
	}
	public void Mute() {
		if (AudioListener.volume == 1) {
			AudioListener.volume = 0;
		}
		else{
			AudioListener.volume = 1;
		}
	}
	public void ErasePlayerPrefs(){
		PlayerPrefs.DeleteAll ();
		Application.LoadLevel (Application.loadedLevel);
	}
	public void LL1() {
		Application.LoadLevel (2);
	}
	public void LL2() {
		Application.LoadLevel (3);
	}
	public void LL3() {
		Application.LoadLevel (4);
	}
	public void LL4() {
		Application.LoadLevel (5);
	}
	public void LL5() {
		Application.LoadLevel (6);
	}
	public void LL6() {
		Application.LoadLevel (7);
	}
	public void LL7() {
		Application.LoadLevel (8);
	}
	public void LL8() {
		Application.LoadLevel (9);
	}
	public void LL9() {
		Application.LoadLevel (10);
	}
	public void LL10() {
		Application.LoadLevel (11);
	}
	public void LL11() {
		Application.LoadLevel (12);
	}
	public void LL12() {
		Application.LoadLevel (13);
	}
	public void LL13() {
		Application.LoadLevel (14);
	}
	public void LL14() {
		Application.LoadLevel (15);
	}
	public void LL15() {
		Application.LoadLevel (16);
	}
	public void LL16() {
		Application.LoadLevel (17);
	}
	public void LL17() {
		Application.LoadLevel (18);
	}
	public void LL18() {
		Application.LoadLevel (19);
	}
	public void LL19() {
		Application.LoadLevel (20);
	}
	public void LL20() {
		Application.LoadLevel (21);
	}
}
