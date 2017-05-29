using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
	public float waitTime;

	[HideInInspector]
	private bool canDoThing = false;
	private float timeElapsed = 0.0f;


	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed > waitTime) {
			timeElapsed = 0.0f;
			canDoThing = false;
		}
		if (canDoThing) {
			Debug.Log ("bleh");
		}
	}
}
