using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {

	private double vertSpeed;
	public double fallingConstant = 0.01;
	public double jumpSpeed = 0.01;

	// Use this for initialization
	void Start () {

		vertSpeed = 0;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;

		if (Input.GetKeyDown ("space"))
			vertSpeed = jumpSpeed;

		pos.y += (float) vertSpeed;

		transform.position = pos;

		vertSpeed -= fallingConstant * Time.deltaTime;
	}
}
