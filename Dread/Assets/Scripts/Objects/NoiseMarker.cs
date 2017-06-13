using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMarker : MonoBehaviour {

	// will create gameoject before destroying it after 4 seconds
	void Start () {
		//Destroys this object after four seconds
		Destroy (this.gameObject, 4F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
