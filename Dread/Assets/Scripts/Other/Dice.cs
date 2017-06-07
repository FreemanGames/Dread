using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour {
	
	public int count;
	public int sides;



	void Start () {
		Random.InitState (System.Environment.TickCount);
	}










	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log (RollOne ());
		}
	}

	public int RollOne()
	{
		return Random.Range (1, sides + 1);
	}

	public int RollAll()
	{
		int runningTotal = 0;

		for (int i = 0; i < count; i++) {
			runningTotal += RollOne ();
		}
		return runningTotal;
	}
}
