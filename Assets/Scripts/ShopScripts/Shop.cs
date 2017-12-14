using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {


	public Text testtext;
	public Text MoneyDisplay;
	public GameObject ObjectToInstan;
	GameObject ClonedObj;
	public GameObject SelectedItem;
	public int PlayerMoney;

	public class Item {
		public string Name;
		public double Price;
		public string Type;

		public Item(string name, double price, string type) {
			Name = name; Price = price; Type = type;
		}
	}

	public List<Item> Inventory = new List<Item>();

	Item Sword = new Item ("Sword", 20, "equipment");
	Item Shield = new Item ("Shield", 25,"equipment");
	Item Potion = new Item ("Potion", 5, "consumable");



	public void AddItem (string item) {
		
		switch (item) {
		case "sword":
			Debug.Log ("Sword costs " + Sword.Price);
			Debug.Log ("You have " + PlayerMoney);
			if (PlayerMoney >= Sword.Price) {
				Inventory.Add (Sword);
				ClonedObj = Instantiate (ObjectToInstan, new Vector3 (), Quaternion.identity) as GameObject;
				ClonedObj.GetComponentInChildren<Text> ().text = "Sword";
				ClonedObj.gameObject.tag = "ItemSword";
				ClonedObj.transform.SetParent (GameObject.FindGameObjectWithTag ("Canvas").transform, false);
				Debug.Log ("Sword added");
				testtext.text = "Sword"; // to do, chanege the button text to sword
			} else {
				Debug.Log ("you dont have enough money");
			}


			break;
		case "shield":
			Inventory.Add (Shield);
			ClonedObj = Instantiate (ObjectToInstan, new Vector3(), Quaternion.identity) as GameObject;
			ClonedObj.GetComponentInChildren<Text>().text = "Shield";
			ClonedObj.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);

			Debug.Log ("shield added");
			testtext.text = "Shield";
			break;
		case "potion":
			Inventory.Add (Potion);
			Debug.Log ("potion added");
			testtext.text = "Potion";
			break;

		default:
			Console.WriteLine ("none");
			break;
		}
	}
	public void SelectItem(){
		SelectedItem = GameObject.FindGameObjectWithTag ("ItemSword");
		Debug.Log ("item Selected");
		Inventory.Remove (Sword);
		Destroy (SelectedItem);

	}


	public void RemoveItem (){
			Inventory.Remove (Sword);
			Destroy (SelectedItem); // 2nd parameter is how long to wait before destroy
			Debug.Log ("sword removed");
		}


	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Money") {
			PlayerMoney ++;
			Debug.Log ("You have " + PlayerMoney);
			MoneyDisplay.text = "Money: " + PlayerMoney.ToString();
			Debug.Log ("Money Added");
			AddItem ("sword");
		}
			
	}
	}


