using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour {

	//agent can detect the player if they are within a 12 meter radius
	public float detectionRange = 12;
	//agent can hear gunshots within a 500 meter radius
	public float gunReach = 500;
	public GameObject player;
	private NavMeshAgent navAgent;
	//gameobject that the agent will move towards
	public GameObject noiseMarker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// function will have the enemy head towards the player or noisemarker
		player = GameObject.FindGameObjectWithTag ("Player");
		navAgent = GetComponent<NavMeshAgent> ();

		noiseMarker = GameObject.FindGameObjectWithTag("NoiseMarker");
		navAgent = GetComponent<NavMeshAgent> ();

		// the radius for the enemy to notice either the player or noisemarker
		if (Vector3.Distance (transform.position, player.transform.position) < detectionRange) {
			navAgent.destination = player.transform.position;
		}
			else if (Vector3.Distance (transform.position, noiseMarker.transform.position) < gunReach) {
				navAgent.destination = noiseMarker.transform.position;
		}
	}
}
