using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour {

	public Collider playerCollider;

	private Collider shipCollider;

	public KeyCode blowUp = KeyCode.Return;

	// Use this for initialization
	void Start () {
		shipCollider = GetComponent<MeshCollider>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (blowUp)) {
			Destroy (gameObject);
		
		}
		
	}


	void OnTriggerEnter(Collider otherCollider) {
		Destroy (gameObject);
	}

}
