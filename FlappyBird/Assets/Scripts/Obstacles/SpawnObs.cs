using UnityEngine;
using System.Collections;

public class SpawnObs : MonoBehaviour {

	public float frequency;

	private float timeToGo;

	public GameObject obs;

	public GameObject ground;

	public GameObject roof;

	// Use this for initialization
	void Start () {

		timeToGo = Time.fixedTime + frequency;
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (Time.fixedTime >= timeToGo) {

			this.transform.position = new Vector3 (transform.position.x, (int) Random.Range(ground.transform.position.y + 1, roof.transform.position.y), transform.position.z);


			for (float i = ground.transform.position.y; i <= roof.transform.position.y; i++) {

				if (i != this.transform.position.y) {
					Instantiate (obs, new Vector3 (this.transform.position.x, i, this.transform.position.z), Quaternion.identity);
				}
			}
			timeToGo = Time.fixedTime + frequency;
		}
	}
}
