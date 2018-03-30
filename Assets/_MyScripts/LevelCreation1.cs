using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelCreation1 : MonoBehaviour {


	public float xStart, xStep, zStart, zStep;
	public GameObject player;
	public GameObject enemy;


	float xCooord , zCoord ;
	char theChar;
	private Vector3 position;
	string levelString;
	string[] levelRows;




	// Use this for initialization
	void Start () {

		string fullFilePath = Application.dataPath + Path.DirectorySeparatorChar + "LevelData.txt";
		if (File.Exists (fullFilePath)) {
			levelString = File.ReadAllText (fullFilePath);
			//bestTime = float.Parse (bestTimeString);
			Debug.Log ("LevelData does exist");
		} else {
			Debug.Log ("LevelData does not exist");
		}

		//levelString = File.ReadAllText("LevelData.txt");
		levelRows = levelString.Split ('\n');
		//Debug.Log (levelRows[5].Length);

		for (int i = 0; i < levelRows.Length; i++) {
			for (int j = 0; j < levelRows[i].Length; j++) {
				theChar = levelRows[i] [j];
				Debug.Log (levelRows[i][j]);
				if (theChar == 'e') {
					position = new Vector3 (xStart + xStep * j, 2, zStart + zStep * i);
					Instantiate (enemy, position, Quaternion.identity);
				}
				if (theChar == 'a') {
					position = new Vector3 (xStart + xStep * j, 2, zStart + zStep * i);
					Instantiate (player, position, Quaternion.identity);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
