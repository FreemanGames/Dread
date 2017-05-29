using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeleport : MonoBehaviour {
	public Transform target;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			transform.position = (target.position);

		}
	}
}
