using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager_script : MonoBehaviour {

	public static GameManager_script instance = null;

	public int score = 0;

	public GameObject ship;
	public float xMin, xMax, zMin, zMax;

	public KeyCode upKey = KeyCode.UpArrow;



	// Use this for initialization
	void Start () {

		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			instance.score = 0;

			Destroy (gameObject);
		}
		
		Vector3 position = new Vector3(Random.Range(xMin, xMax), 2, Random.Range(zMin, zMax));
		Instantiate(ship, position, Quaternion.identity);
		position = new Vector3(Random.Range(xMin, xMax), 2, Random.Range(zMin, zMax));
		Instantiate(ship, position, Quaternion.identity);
		position = new Vector3(Random.Range(xMin, xMax), 2, Random.Range(zMin, zMax));
		Instantiate(ship, position, Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(upKey)){
			instance.score++;
		}

	}
}
