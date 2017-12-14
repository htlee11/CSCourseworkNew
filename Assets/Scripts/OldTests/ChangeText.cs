using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {
	[SerializeField]

	public Text testtext;
	// Use this for initialization
	void Start () {
		testtext.text = "Hi.........";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
