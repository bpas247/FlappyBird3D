using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (Text))]
public class CurrentScoreHandler : MonoBehaviour {

	private float currentScore;
	private Text txt;
	private GameObject roof;
	// Use this for initialization
	void Start () {
		currentScore = 0;
		txt = GetComponent<Text> ();
		roof = GameObject.FindGameObjectWithTag ("Roof");
	}
	
	public void addToScore() { currentScore++; }
	public float getScore() { return currentScore; }
	public void setScore(float i) { currentScore = i; }

	// Update is called once per frame
	void Update () {

		txt.text = "Current Score: " + Mathf.Round(currentScore);
	}
}
