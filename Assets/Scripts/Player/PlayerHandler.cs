using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {

	private double vertSpeed;

	public double fallingConstant = 0.01;
	public double jumpSpeed = 0.01;

	private GameObject roof;
	private GameRegistery registery;
	// Use this for initialization
	void Start () {

		vertSpeed = 0;
		roof = GameObject.FindGameObjectWithTag ("Roof");
		registery = (GameRegistery) GameObject.FindGameObjectWithTag ("Registery").GetComponent(typeof(GameRegistery));

	}
	
	// Update is called once per frame
	void Update () {

		if(registery.getIsGameRunning())
			jumpHandler();
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject != roof)
			registery.setIsGameRunning (false);
	}

	void jumpHandler () {

		Vector3 pos = transform.position;

		if (Input.GetKeyDown ("space") && this.transform.position.y < roof.transform.position.y)
			vertSpeed = jumpSpeed;

		pos.y += (float) vertSpeed;

		transform.position = pos;

		vertSpeed -= fallingConstant * Time.deltaTime;
	}
}