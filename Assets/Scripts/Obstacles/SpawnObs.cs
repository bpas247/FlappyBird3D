using UnityEngine;
using System.Collections;

public class SpawnObs : MonoBehaviour {

	public float frequency;

	private float timeToGo;

	public GameObject obs;

	private GameObject ground;

	private GameObject roof;

	private GameRegistery registery;

	// Use this for initialization
	void Start () {

		timeToGo = Time.fixedTime + frequency;

		ground = GameObject.FindGameObjectWithTag ("Floor");
		roof = GameObject.FindGameObjectWithTag ("Roof");
		registery = GameObject.FindGameObjectWithTag ("Registery").GetComponent<GameRegistery>();
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (registery.getIsGameRunning ()) {
			if (Time.fixedTime >= timeToGo) {

				this.transform.position = new Vector3 (transform.position.x, (int) Random.Range (ground.transform.position.y + 1, roof.transform.position.y), transform.position.z);


				for (float i = ground.transform.position.y; i <= roof.transform.position.y; i++) {

					if (i != this.transform.position.y) {
						Instantiate (obs, new Vector3 (transform.position.x, i, transform.position.z), Quaternion.identity);
					}
				}
				timeToGo = Time.fixedTime + frequency;
			}
		}
	}
}
