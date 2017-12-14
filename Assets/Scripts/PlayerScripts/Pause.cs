using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
	
	public GameObject PauseUI;
	bool Paused = false;

	void Start(){
		Paused = false;
	}

	void Update(){
		if(Input.GetButtonDown("Pause")){
			Paused = !Paused;
			if (Paused) {
				PauseUI.SetActive (true);
				Time.timeScale = 0;
			} else if (!Paused) {
				PauseUI.SetActive (false);
				Time.timeScale = 1;
			}
		}
	}
		
	public void PauseBtn (){
		Paused = !Paused;
		if (Paused) {
			PauseUI.SetActive (true);
			Time.timeScale = 0;
		} else if (!Paused) {
			PauseUI.SetActive (false);
			Time.timeScale = 1;
		}
	}
}
