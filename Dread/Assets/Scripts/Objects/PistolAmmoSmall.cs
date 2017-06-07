using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoSmall : MonoBehaviour {

	public int ammoAdd = 7;

	// Use this for initialization
	void Start () {

	}

		void OnTriggerEnter(Collider other){
			if (other.tag == "Player") {
			other.GetComponent<Shooting>().addAmmo (ammoAdd);
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
