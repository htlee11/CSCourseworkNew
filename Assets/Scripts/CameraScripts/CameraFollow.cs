using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	void FixedUpdate(){
		float horizontal = Input.GetAxis ("Horizontal");
		flip (horizontal);

	}

	void flip (float horizontal){ // for fliping the player left or right
		if (horizontal < 0) {
			transform.localScale = new Vector3 (1, 1, 1);
		}
		if (horizontal > 0) {
			transform.localScale = new Vector3 (-1, 1, 1);
		}
	}
}
