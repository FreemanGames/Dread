using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int health = 6;
	public Transform target;

	public void TakeDamage(int damageToTake) {
		health = health - damageToTake;
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			DestroyObject;
		}
	}
}
