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
		Debug.Log( Vector3.Lerp(new Vector3(0,0,0), new Vector3(1,1,1), 0.5f));
	}
	
	// Update is called once per frame
	void Update () {

	//	direction = GetComponentInParent.transfor
		Vector3 eulerAngles = transform.localRotation.eulerAngles;
		eulerAngles += rotateAxis * rotateSpeed * Time.deltaTime;
		transform.localRotation = Quaternion.Euler (eulerAngles);
		
	}
}
