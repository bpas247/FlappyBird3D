using UnityEngine;
using System.Collections;

public class GameRegistery : MonoBehaviour {

	private bool isGameRunning;
	private GameObject player;
	private CurrentScoreHandler currentScore;
	// Use this for initialization
	void Start () {
		isGameRunning = true;
		player = GameObject.FindGameObjectWithTag ("Player");
		currentScore = (CurrentScoreHandler) GameObject.FindGameObjectWithTag ("CS").GetComponent (typeof (CurrentScoreHandler));
	}
	
	public bool getIsGameRunning () {
		return isGameRunning;
	}

	public void setIsGameRunning(bool b) {
		isGameRunning = b;
	}

	// Update is called once per frame
	void Update () {

		if (isGameRunning == false && Input.GetKeyDown ("space")) {
			Vector3 playerP = player.transform.position;
			playerP.y = 3;
			player.transform.position = playerP;
			GameObject[] obs = GameObject.FindGameObjectsWithTag ("Obs");

			for (int i = 0; i < obs.Length; i++)
				GameObject.Destroy (obs[i]);

			currentScore.setScore (0);

			this.setIsGameRunning (true);
		}
	}
}
