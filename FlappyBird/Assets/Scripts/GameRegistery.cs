using UnityEngine;
using System.Collections;

public class GameRegistery : MonoBehaviour {

	private bool isGameRunning;

	// Use this for initialization
	void Start () {
		isGameRunning = true;
	}
	
	public bool getIsGameRunning () {
		return isGameRunning;
	}

	public void setIsGameRunning(bool b) {
		isGameRunning = b;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
