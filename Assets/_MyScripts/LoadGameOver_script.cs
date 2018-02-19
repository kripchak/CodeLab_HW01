using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameOver_script : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		CheckScore ();

	}

	void CheckScore(){

		if (GameManager_script.instance.score >= GameManager_script.instance.goalScore) {
			SceneManager.LoadScene ("Scene02");
		}

	}
}
