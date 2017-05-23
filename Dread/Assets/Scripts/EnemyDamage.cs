using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public int damage = 1;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			other.GetComponent<PlayerHealth>().TakeDamage (damage);

		}
	}

}
