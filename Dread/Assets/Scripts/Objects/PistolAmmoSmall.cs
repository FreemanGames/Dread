using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoSmall : MonoBehaviour {

	//how much ammo will added to the players weapon
	public int ammoAdd = 7;

	// Use this for initialization
	void Start () {

	}
	// when touching a collider check if its tag is player, if yes add 7 to the ammo value before destroying this gameobject
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
