using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		float disanceOfRay = 100;

		if (Physics.Raycast (ray, out hit, disanceOfRay)) {
			if (other.tag == "Enemy") {
				other.GetComponent<EnemyHealth>().TakeDamage (damage);

		}
}
