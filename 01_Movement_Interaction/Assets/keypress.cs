using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypress : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;

	// Use this for initialization
	void Start () {

		moveSpeed = 1;
		turnSpeed = 1;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)){
//			transform.Translate (new Vector3 (0, -1, 0));
			transform.Translate(Vector3.forward * moveSpeed);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.back * moveSpeed);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate (new Vector3 (0, -turnSpeed, 0));
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate (new Vector3 (0, turnSpeed, 0));
		}

//		transform.Translate (new Vector3 (0, 0, moveSpeed) * Time.deltaTime);
		
	}

//	void OnMouseDown(){
//		Debug.Log ("clicked!!");
//		transform.Translate (new Vector3 (0,1,0));
//	}
}
