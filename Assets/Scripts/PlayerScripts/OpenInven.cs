using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenInven : MonoBehaviour {
	public GameObject InvenCanvas;
	bool InvenOpened;

	void Start(){
		InvenOpened = false;
	}

	void Update () {
		OpenInv();

	}
	void OpenInv (){

		if (Input.GetButtonDown("Inventory")) {
			InvenOpened = !InvenOpened;
			if (InvenOpened) {
				Debug.Log ("Inventory Opened");
				InvenCanvas.gameObject.SetActive (true);
			} else if (!InvenOpened) {
				Debug.Log ("Inventory Closed");
				InvenCanvas.gameObject.SetActive (false);
			}


		} 
	}
}
