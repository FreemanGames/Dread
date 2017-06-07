using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour {



	public Text herText;
	private int line;
	public float lineDelay = 1.0f;
	private float timer;



	// Use this for initialization
	void Start () {
			line = Random.Range (0, 7);
				
			if (line == 1) {
				Debug.Log ("1");
				herText.text = "1";
			}

				if (line == 2) {
				Debug.Log ("2");
				herText.text = "2";
			}
					
				if (line == 3) {
				Debug.Log ("3");
				herText.text = "3";
			}
					
				if (line == 4) {
				Debug.Log ("4");
				herText.text = "4";
			}
					
				if (line == 5) {
				Debug.Log ("5");
				herText.text = "5";
			}
					
				if (line == 6) {
				Debug.Log ("6");
				herText.text = "6";

				if (Time.time - timer > lineDelay){
					timer = Time.time;

			}
		}
	}
	}