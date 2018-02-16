using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_script : MonoBehaviour {

	public GameObject ship;
	public float xMin, xMax, zMin, zMax;

	// Use this for initialization
	void Start () {
		
		Vector3 position = new Vector3(Random.Range(xMin, xMax), 2, Random.Range(zMin, zMax));
		Instantiate(ship, position, Quaternion.identity);
		Vector3 position2 = new Vector3(Random.Range(xMin, xMax), 2, Random.Range(zMin, zMax));
		Instantiate(ship, position2, Quaternion.identity);
		Vector3 position3 = new Vector3(Random.Range(xMin, xMax), 2, Random.Range(zMin, zMax));
		Instantiate(ship, position3, Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
