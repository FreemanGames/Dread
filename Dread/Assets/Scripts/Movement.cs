using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speedH = 2.0f;
	public bool grounded = true;
	public float speed = 0.2f;
	public float sprintSpeed = 0.15f;
	public float strafeSpeed = 0.075f;
	public float backUpSpeed = -0.05f;
	private float xRotate = 0.0f;
	public float rotationSpeed = 10.0f;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		// movement
		if (Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * speed;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += transform.forward * backUpSpeed;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += transform.right * -strafeSpeed;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += transform.right * strafeSpeed;
		}
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.LeftShift)) {
			transform.position += transform.forward * sprintSpeed;
		}
		if (Input.GetKeyDown (KeyCode.Space) && grounded == true) {
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 200);
			grounded = false;
		}
		{
			//mouselook
			xRotate += speedH * Input.GetAxis("Mouse X");
			transform.eulerAngles = new Vector3(0.0f, xRotate, 0.0f);

			if (Input.GetKeyDown ("escape"))
				Cursor.lockState = CursorLockMode.None;
		}
	}
	void OnCollisionEnter(){
		grounded = true;
	}
}