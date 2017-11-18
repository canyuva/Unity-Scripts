using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Can Yuva
// github.com/canyuva

public class PlayerMovementwithJump : MonoBehaviour {

	public float movementSpeed = 30.0f;
	private float Vector3;
	public float jumpSpeed = 50.0f;
	public Rigidbody rb;
	public float thrust = 300.0f;
	public Collider cd;
	public Transform transform;
	public bool isGrounded = true;
	float x, z;
	public Animator animator;
	
	void Start (){
	
		rb = GetComponent<Rigidbody>();
		transform = GetComponent<Transform>();
		animator = GetComponent<Animator>();
		
	}
	void Update () {
		
		if(isGrounded){
			x = Input.GetAxis ("Horizontal") * Time.deltaTime * movementSpeed;
			z = Input.GetAxis ("Vertical") * Time.deltaTime * movementSpeed;
			if(x<0)
				animator.Play("Left");
			if(x>0)
				animator.Play("Right");
			if(z>0)
				animator.Play("Run");
			if(z<0)
				animator.Play("Run_Back");
			if(x == 0 && z == 0)
				animator.Play("Idle");
		}
		transform.Translate (x, 0, z);
		if(Input.GetButtonDown("Jump")){
			  if(isGrounded){
				rb.AddForce(transform.up * thrust); 
				animator.Play("Idle");
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
