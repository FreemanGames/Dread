﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speedH = 2.0f;


	private float yaw = 0.0f;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// movement
		if (Input.GetKey (KeyCode.W)) {
			transform.position = transform.position + new Vector3 (0, 0, 0.1f);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position = transform.position + new Vector3 (0, 0, -0.075f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position = transform.position + new Vector3 (-0.075f, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position = transform.position + new Vector3 (0.05f, 0, 0);
		}
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.LeftShift)) {
			transform.position = transform.position + new Vector3 (0, 0, 0.15f);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 200);
		}
		{

			yaw += speedH * Input.GetAxis("Mouse X");


			transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);

			if (Input.GetKeyDown ("escape"))
				Cursor.lockState = CursorLockMode.None;
		}

	}
}