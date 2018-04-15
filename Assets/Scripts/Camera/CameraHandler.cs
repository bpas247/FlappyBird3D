using UnityEngine;
using System.Collections;

public class CameraHandler : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = new Vector3 (this.transform.position.x, player.transform.position.y, this.transform.position.z);
	}
}
