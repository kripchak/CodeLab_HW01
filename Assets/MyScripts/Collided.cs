using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour {

	private Collider shipCollider;

	// Use this for initialization
	void Start () {
		shipCollider = GetComponent<MeshCollider>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
