using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
	// enemy health = 6
	public int health = 6;

	public void TakeDamage(int damageToTake) {
		health = health - damageToTake;
	}

	// Use this for initialization
	void Start () {

	}

	// if health = 0 destroy the object
	void Update () {
		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}
}
