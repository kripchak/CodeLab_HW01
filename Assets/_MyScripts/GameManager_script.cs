using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;


public class GameManager_script : MonoBehaviour {

	public static GameManager_script instance = null;

	public int score = 0;
	public int goalScore = 4;
	public int numberOfShips = 8;

	public GameObject ship;
	public float xMin, xMax, zMin, zMax;

	public KeyCode upKey = KeyCode.UpArrow;
	public KeyCode dieKey = KeyCode.Return;

	private Vector3 position;


	// Use this for initialization
	void Start () {

		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			instance.score = 0;

			Destroy (gameObject);
		}
		
		for (int i = 1; i <= numberOfShips; i++) {

			position = new Vector3 (Random.Range (xMin, xMax), 2, Random.Range (zMin, zMax));
			Instantiate (ship, position, Quaternion.identity);
			//Debug.Log ("Here " + i);


			//File.WriteAllText (Application.persistentDataPath +Path.DirectorySeparatorChar + "Save_data.txt", "THIS IS A TEST");

		}
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(upKey)){
			instance.score++;
		}

		if (Input.GetKey(dieKey)){
			SceneManager.LoadScene ("Scene02");

		}


	}




}