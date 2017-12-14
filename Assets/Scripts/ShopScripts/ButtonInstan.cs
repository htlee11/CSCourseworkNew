using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInstan : MonoBehaviour {
	public GameObject ObjectToInstan;
	GameObject ClonedObj;

	void Start(){


		int loop = 0;
		for (int i = 0 ; i < 5; i++) {
			loop++;
			ClonedObj = Instantiate (ObjectToInstan, new Vector3(loop * 10,0,0), Quaternion.identity) as GameObject;
			ClonedObj.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);

		}


	}
			
}
