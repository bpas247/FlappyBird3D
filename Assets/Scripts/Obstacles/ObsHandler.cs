﻿using UnityEngine;
using System.Collections;

public class ObsHandler : MonoBehaviour {


    public float moveSpeed = 2;
	private GameObject player;
	private GameRegistery registery;
	private CurrentScoreHandler currentScore;
	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
		registery = (GameRegistery) GameObject.FindGameObjectWithTag ("Registery").GetComponent (typeof (GameRegistery));
		currentScore = (CurrentScoreHandler) GameObject.FindGameObjectWithTag ("CS").GetComponent (typeof (CurrentScoreHandler));
	}
	
	// Update is called once per frame
	void Update () {

		if (registery.getIsGameRunning ()) {
			if (transform.position.x > (player.transform.position.x - transform.lossyScale.x))
				transform.Translate (new Vector3 (-1 * moveSpeed, 0, 0) * Time.deltaTime);
			else {
				currentScore.setScore (currentScore.getScore() + 1f/6f);
				GameObject.Destroy (gameObject);
			}
		}
	}
}