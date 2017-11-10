using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour {

	public int health = 100;
	public Text healthText;
	
	void Start(){
		
		healthText.text = health.ToString() + " can kaldı.";
	}
	// Update is called once per frame
	void Update (){
		if(Input.GetKeyDown(KeyCode.K) && health != 0){
			health -= 5;
			healthText.text = health.ToString() + " can kaldı.";
		}
		if(health == 0)
			die();
	}
	void die(){}
}
