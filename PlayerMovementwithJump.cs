using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

		// Components for your Player  || Player için gerekli bileşenler
		// 1- Rigidbody
		// 2- Box Collider for isGrounded checking || isGrounded kontrolü için box collider
		


	public float movementSpeed = 30.0f;
	private float Vector3;
	public float jumpSpeed = 50.0f;
	public Rigidbody rb;
	public float thrust = 300.0f;
	public Collider cd;
	public Transform transform;
	public bool isGrounded = true;
	float x, z;
	void Start (){
	
		rb = GetComponent<Rigidbody>();
		transform = GetComponent<Transform>();
	
	}
	void Update () {
		
		if(isGrounded){
			x = Input.GetAxis ("Horizontal") * Time.deltaTime * movementSpeed;
			z = Input.GetAxis ("Vertical") * Time.deltaTime * movementSpeed;
		}
			transform.Translate (x, 0, z);

		 if(Input.GetButtonDown("Jump")){
			 
			  
			  if(isGrounded){
				rb.AddForce(transform.up * thrust);
			  }
		 }
		 
	}
	
	void OnTriggerEnter(Collider cd){
		isGrounded = true;
	}
	void OnTriggerExit(Collider cd){
		isGrounded = false;
	}
}
