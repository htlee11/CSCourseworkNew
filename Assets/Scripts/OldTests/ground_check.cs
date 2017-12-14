using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_check : MonoBehaviour {
	private player player;

	void Start()
	{
		player = gameObject.GetComponentInParent<player> ();

	}
	void OnTriggerEnter2D(Collider2D col)
	{
		player.grounded = true;

	}


	void OnTriggerExit2D(Collider2D col)
	{
		player.grounded = false;

	}
}
