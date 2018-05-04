using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {

	private Rigidbody rbPlayer;
	private Rigidbody rbAsteroid;
	public float speed;
	public float xMin, xMax, zMin, zMax;
	public GameObject asteroidGameObject;
	public Vector3 hitLocation;

	public KeyCode dieKey = KeyCode.Space;


	// Use this for initialization
	void Start () {

		rbPlayer = GetComponent<Rigidbody> ();
		rbAsteroid = asteroidGameObject.GetComponent<Rigidbody> ();
		
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Vector3 mouseScreenPos = Input.mousePosition;
			mouseScreenPos.z = 0;
			Ray mouseRay = Camera.main.ScreenPointToRay (mouseScreenPos);
			RaycastHit hitInfo;
			Debug.Log (mouseScreenPos);

			if (Physics.Raycast (mouseRay, out hitInfo)) {
				hitLocation = hitInfo.point;
				//Debug.Log (hitLocation);
				//Debug.Log ("hi");

				//Debug.Log(hitInfo.collider);

			}
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		 float moveVertical = Input.GetAxis ("Vertical");
		Vector3 toTarget = hitLocation - transform.position;
		Vector3 movement = new Vector3 (toTarget.x, 0.0f, toTarget.z);

		//rbPlayer.velocity = movement*speed*Time.deltaTime;
		rbPlayer.AddForce(movement*speed);

		rbPlayer.position = new Vector3 (
			Mathf.Clamp (rbPlayer.position.x, xMin, xMax),
			2.0f,
			Mathf.Clamp (rbPlayer.position.z, zMin, zMax)
		);

	}




}



