using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class StartOverScript : MonoBehaviour {

	public KeyCode startOver = KeyCode.Space;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (startOver)) {
			SceneManager.LoadScene ("Scene01");
		}
			

	}
}
