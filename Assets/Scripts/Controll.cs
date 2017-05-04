using UnityEngine;  
using System.Collections;
using System.Collections.Generic;


public class Controll : MonoBehaviour {


	public float movementSpeed, mouseSpeed, rotationuppner, lasvinkel, acceleration, JumpForce;

	CharacterController cc;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {

		float rotationhogervanster = Input.GetAxis ("Mouse X") * mouseSpeed;
		transform.Rotate (0, rotationhogervanster, 0);

		rotationuppner -= Input.GetAxis ("Mouse Y") * mouseSpeed;
		rotationuppner = Mathf.Clamp (rotationuppner, -lasvinkel, lasvinkel);
		Camera.main.transform.localRotation = Quaternion.Euler(rotationuppner, 0, 0);

		// Updatering variabeln
		float speedForward = Input.GetAxis("Vertical") * movementSpeed;
		float speedSideStep = Input.GetAxis("Horizontal") * movementSpeed;


		acceleration += Physics.gravity.y * Time.deltaTime;

		if (cc.isGrounded && Input.GetButton ("Jump")) 
		{
			acceleration = JumpForce;
		}


		Vector3 speed = new Vector3 (speedSideStep, acceleration, speedForward);

		speed = transform.rotation * speed;

		cc.Move (speed * Time.deltaTime);

		//Kontrollera knapp
		
	}

}
