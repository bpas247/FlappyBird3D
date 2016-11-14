using UnityEngine;
using System.Collections;

public class ObsHandler : MonoBehaviour {


    public float moveSpeed = 2;
	private GameObject player;
	private GameRegistery registery;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");
		registery = (GameRegistery) GameObject.FindGameObjectWithTag ("Registery").GetComponent (typeof (GameRegistery));
	}
	
	// Update is called once per frame
	void Update () {

		if (registery.getIsGameRunning ()) {
			if (transform.position.x > (player.transform.position.x - this.transform.lossyScale.x))
				transform.Translate (new Vector3 (-1 * moveSpeed, 0, 0) * Time.deltaTime);
			else
				GameObject.Destroy (gameObject);
		}
	}
}