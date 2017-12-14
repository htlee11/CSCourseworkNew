using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenShop : MonoBehaviour 
{
	public GameObject ShopCanvas;
	public GameObject InvenCanvas;

	void OnTriggerEnter2D(Collider2D col){
		ShopCanvas.gameObject.SetActive (true);
		InvenCanvas.gameObject.SetActive (true);
			Debug.Log ("you opened the shop");
	}

	void OnTriggerExit2D(Collider2D col){
		ShopCanvas.gameObject.SetActive (false);
		InvenCanvas.gameObject.SetActive (false);
	}


}
