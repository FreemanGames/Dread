using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
	//health is set to 1
	public int health = 1;
	// string is public so you can edit it in the inspector
	public string loadLevel;

	public void TakeDamage(int damageToTake) {
		health = health - damageToTake;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//will change the scene when the players health hits 0
		if (health <= 0) {
			SceneManager.LoadScene (loadLevel, LoadSceneMode.Single);
		}
	}
}
