using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	public float speed;
	public GameObject target;


	
	// Update is called once per frame
	void Update () {
		//transform.LookAt (Target.transform);
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
	}
}
