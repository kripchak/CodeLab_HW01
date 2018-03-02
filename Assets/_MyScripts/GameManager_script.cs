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
	public float time = 0.0f;
	public float bestTime = 20.0f; 

	public GameObject ship;
	public float xMin, xMax, zMin, zMax;

	public KeyCode upKey = KeyCode.UpArrow;
	public KeyCode dieKey = KeyCode.Return;

	private Vector3 position;
	private float startTime = 0.0f;


	// Use this for initialization
	void Start () {

		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			instance.score = 0;
			instance.startTime = Time.time;

			Destroy (gameObject);
		}
		
		for (int i = 1; i <= numberOfShips; i++) {

		//	position = new Vector3 (Random.Range (xMin, xMax), 2, Random.Range (zMin, zMax));
		//	Instantiate (ship, position, Quaternion.identity);
			//Debug.Log ("Here " + i);
		}

			//File.WriteAllText (Application.persistentDataPath +Path.DirectorySeparatorChar + "Save_data.txt", "THIS IS A TEST");
		string fullFilePath = Application.dataPath + Path.DirectorySeparatorChar + "SaveData.txt";
		if (File.Exists (fullFilePath)) {
			string bestTimeString = File.ReadAllText (fullFilePath);
			//bestTime = float.Parse (bestTimeString);
			Debug.Log ("SaveData does exist");
		} else {
			Debug.Log ("SaveData does not exist");
		}



		}



		public void endGame() {
		time = Time.time - startTime;

			if (time < bestTime ) {
				bestTime = time ;

			string fullFilePath = Application.dataPath + Path.DirectorySeparatorChar + "SaveData.txt";
			File.WriteAllText (fullFilePath, bestTime.ToString ());
		}
		SceneManager.LoadScene ("Scene02");
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