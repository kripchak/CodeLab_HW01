using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinObject : MonoBehaviour {

	//new Vector3 direction;
	public float rotateSpeed = 180f;
	public Vector3 rotateAxis;

	// Use this for initialization
	void Start () {
	//	rb = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {

	//	direction = GetComponentInParent.transform
		Vector3 eulerAngles = transform.localRotation.eulerAngles;
		eulerAngles += rotateAxis * rotateSpeed * Time.deltaTime;
		transform.localRotation = Quaternion.Euler (eulerAngles);
		
	}
}
