using UnityEngine;
using System.Collections;

public class ObsHandler : MonoBehaviour {


    public float moveSpeed = 2;
	private GameObject player;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x > (player.transform.position.x - this.transform.lossyScale.x))
			transform.Translate (new Vector3 (-1 * moveSpeed, 0, 0) * Time.deltaTime);
		else
			GameObject.Destroy (gameObject);
	}
}