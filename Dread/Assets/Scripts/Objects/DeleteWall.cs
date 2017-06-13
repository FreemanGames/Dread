using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWall : MonoBehaviour {

	void Start () {
		//destroys the gameobject after 4 seconds
		Destroy (this.gameObject, 4F);
	}
}
