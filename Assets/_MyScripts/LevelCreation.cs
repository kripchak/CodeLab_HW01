using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelCreation : MonoBehaviour {


	public float xStart, xStep, zStart, zStep;
	public GameObject player;
	public GameObject enemy;


	float xCooord , zCoord ;
	char theChar;
	Vector3 position;
	string levelString;
	string[] levelRows;




	// Use this for initialization
	void Start () {
		levelString = File.ReadAllText("LevelData.txt");
		levelRows = levelString.Split ('\n');
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < levelRows.Length; i++) {
			for (int j = 0; j < levelRows [i].Length; j++) {
				theChar = levelRows [i] [j];
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
}
