using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {
	
	public GameObject raycastMarker;

	public int ammoCount = 0;
	public int clipSize = 7;
	public int clipCount = 7;
	public GameObject noise;
	public bool reloaded = true;
	private float reloadDelay = 3.0f;

	public Text ammoText;
	public Text clipText;

	public float timeBetweenBullets = 1.0f;
	private float timer;
	public int damage = 1;

	public AudioClip shootSound;
	public AudioClip reloadSound;
	public AudioClip dryFireSound;
	private AudioSource source;

	private float volLowRange = 1.0f;
	private float volhighRange = 1.0f;

	public Transform noiseMaker;


	void Start(){
		UpdateText ();
		timer = Time.time;


	}



	void Awake () {
		source = GetComponent<AudioSource> ();
	}


	private void Reload(){
		ammoCount += clipCount;


		if (ammoCount > clipSize) {
			clipCount = clipSize;
			ammoCount -= clipSize;
		} else {
			clipCount = ammoCount;
				ammoCount = 0;
		}
		UpdateText ();
	}
	private void UpdateText() {
		ammoText.text = ammoCount.ToString ();
			clipText.text = clipCount.ToString ();
	}

	public void addAmmo(int addAmmo) {
		ammoCount = ammoCount + addAmmo;
		UpdateText ();
	}

	private void DryFire(){
		float vol = Random.Range (volLowRange, volhighRange);
		source.PlayOneShot (dryFireSound, vol);
	}




	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R) && reloaded == true) {
			float vol = Random.Range (volLowRange, volhighRange);
			source.PlayOneShot (reloadSound, vol);
			reloaded = false;
			Invoke ("Reload", 3);
				
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			UpdateText ();

		}


	
		if (Input.GetMouseButtonDown (0) && reloaded == true) {
			if (Time.time - timer > timeBetweenBullets){
				timer = Time.time;
			if (clipCount > 0) {
					float vol = Random.Range (volLowRange, volhighRange);
					source.PlayOneShot (shootSound, vol);

				clipCount--;
					UpdateText ();
					GameObject Go = Instantiate (noise, noiseMaker.position, Quaternion.identity) as GameObject;

			RaycastHit hit;

			if (Physics.Raycast (transform.position, transform.forward, out hit, 50f)) {
						hit.rigidbody.GetComponent<EnemyHealth>().TakeDamage (damage);
				
					}


				}
			}
		}
		if (Input.GetMouseButtonDown (0) && reloaded == true) {
				if (clipCount == 0) {
				Invoke ("DryFire",0);
				}
			}

		if (reloaded == false) {
			if (Time.time - timer > reloadDelay){
				timer = Time.time;

			reloaded = true;
		}
		}
	}
}
			