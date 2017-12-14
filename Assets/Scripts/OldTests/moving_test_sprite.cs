using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_test_sprite : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float speed;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		movement (horizontal);
        

	}
	private void movement(float horizontal)
	{
		rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);


	}
}
