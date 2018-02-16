using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour {

	private Rigidbody rbParent;
	//private Rigidbody rbAsteroid;
	private Rigidbody rb;
	public float angleX,angleY,angleZ;


	// Use this for initialization
	void Start () {
		//rbParent = GetComponentInParent <Rigidbody>();
		//rbAsteroid = GetComponent <Rigidbody> ();
		rb = GetComponent <Rigidbody> ();
		//spin = (angleX, angleY, angleZ);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log (rbAsteroid.velocity);
		//Debug.Log (rbParent.position);
		//rb.angularVelocity = rb.velocity;
		//rb.rotation = rb.velocity;
	}
}
