using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
	public int health = 1;
	public string loadLevel;

	public void TakeDamage(int damageToTake) {
		health = health - damageToTake;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			SceneManager.LoadScene (loadLevel, LoadSceneMode.Single);
		}
	}
}
