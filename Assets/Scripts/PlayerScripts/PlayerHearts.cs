using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHearts : MonoBehaviour {

	private int maxHearts = 5;
	public int CurHearts;
	public Image[] Hearts;
	public PlayerMovement movement;

	void Start () {
		CurHearts = maxHearts;
	}

	void OnTriggerEnter2D(Collider2D col){
		
		if (col.tag == "EnemySprite") {
			TakeDamage ();
			HeartsUIRemove ();
		}else if (col.tag == "Heart") {
			AddHearts ();
		}

	}
	void HeartsUIRemove(){
		CheckIfDead ();
		Hearts [CurHearts].enabled = false;
	}

	void TakeDamage(){
		Debug.Log ("health - 1");
		CurHearts--;
	}

	void CheckIfDead(){
		if (CurHearts == 0) {// less than or equal
			movement.enabled = false;
		}
	}

	void AddHearts(){
		if (CurHearts != maxHearts) {// use less than
			Debug.Log ("health + 1");
			CurHearts++;
			HeartsUIAdd ();
		} else {
			Debug.Log ("Health Full");
		}
	}

	void HeartsUIAdd(){
		Hearts [CurHearts -1 ].enabled = true;
	}
}
