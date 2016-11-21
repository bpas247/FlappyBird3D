using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (Text))]
public class MaxScoreHandler : MonoBehaviour {

	private float maxScore;
	private CurrentScoreHandler cs;
	private Text txt;
	// Use this for initialization
	void Start () {
		maxScore = 0;
		cs = GameObject.FindGameObjectWithTag ("CS").GetComponent<CurrentScoreHandler> ();
		txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

		if (cs.getScore () > maxScore)
			maxScore = cs.getScore ();

		txt.text = "Max Score: " + Mathf.Round(maxScore);
	}
}
