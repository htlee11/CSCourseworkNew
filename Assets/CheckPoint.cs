﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "CheckPoint") {
			Debug.Log ("Checkpoint Reached");
		}
	}
}
