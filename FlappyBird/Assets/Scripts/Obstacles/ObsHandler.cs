using UnityEngine;
using System.Collections;

public class ObsHandler : MonoBehaviour {


    public double moveSpeed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (transform.position.x >= -5)
			transform.Translate (new Vector3 (-1 * 2, 0, 0) * Time.deltaTime);
		else
			GameObject.Destroy (gameObject);
	}
}