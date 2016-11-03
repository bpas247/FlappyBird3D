using UnityEngine;
using System.Collections;

public class SpawnObs : MonoBehaviour {

	public float frequency;

	private float timeToGo;

	 public GameObject obs;

	// Use this for initialization
	void Start () {

		timeToGo = Time.fixedTime + frequency;
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (Time.fixedTime >= timeToGo) {

			this.transform.position = new Vector3 (transform.position.x, Random.Range(1, 6), transform.position.z);

			Instantiate (obs, this.transform.position, Quaternion.identity);
			timeToGo = Time.fixedTime + frequency;
		}
	}
}
