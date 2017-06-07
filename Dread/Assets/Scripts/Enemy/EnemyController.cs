using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour {

	public float detectionRange = 12;
	public float gunReach = 500;
	public GameObject player;
	private NavMeshAgent navAgent;
	public GameObject noiseMarker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		navAgent = GetComponent<NavMeshAgent> ();

		noiseMarker = GameObject.FindGameObjectWithTag("NoiseMarker");
		navAgent = GetComponent<NavMeshAgent> ();


		if (Vector3.Distance (transform.position, player.transform.position) < detectionRange) {
			navAgent.destination = player.transform.position;
		}
			else if (Vector3.Distance (transform.position, noiseMarker.transform.position) < gunReach) {
				navAgent.destination = noiseMarker.transform.position;
		}
	}
}
