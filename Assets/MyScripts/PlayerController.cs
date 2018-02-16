using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rbPlayer;
	private Rigidbody rbAsteroid;
	public float speed;
	public float xMin, xMax, zMin, zMax;
	public GameObject asteroidGameObject;

	// Use this for initialization
	void Start () {

		rbPlayer = GetComponent<Rigidbody> ();
		rbAsteroid = asteroidGameObject.GetComponent<Rigidbody> ();

		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rbPlayer.velocity = movement*speed*Time.deltaTime;


		rbPlayer.position = new Vector3 (
			Mathf.Clamp (rbPlayer.position.x, xMin, xMax),
			0.0f,
			Mathf.Clamp (rbPlayer.position.z, zMin, zMax)
		);
		//rbAsteroid.angularVelocity = movement*speed*Time.deltaTime;
	//	Debug.Log (rbAsteroid.velocity);
		Debug.Log (asteroidGameObject.transform.localRotation);
	}
}
