using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWall : MonoBehaviour {

	void Start () {
		Destroy (this.gameObject, 4F);
	}
}
