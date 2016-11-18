using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentScoreHandler : MonoBehaviour {

	private int currentScore;
	private Text txt;
	private GameObject roof;
	// Use this for initialization
	void Start () {
		currentScore = 0;
		txt = GetComponent<Text> ();
		roof = GameObject.FindGameObjectWithTag ("Roof");
	}
	
	public void addToScore() { currentScore++; }
	public int getScore() { return currentScore; }
	public void setScore(int i) { currentScore = i; }

	// Update is called once per frame
	void Update () {

		txt.text = "Current Score: " + currentScore;
	}
}
