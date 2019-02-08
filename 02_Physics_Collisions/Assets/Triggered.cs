﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered : MonoBehaviour {

	Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void OnTriggerEnter (Collider other){
		
	}

	void OnTriggerStay (Collider other){
		rb.AddForce (Vector3.up*10);
		rb.AddTorque (Vector3.right * 10);
	}

	void OnTriggerExit(Collider other){
		
	}
}
