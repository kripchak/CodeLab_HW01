using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore_script : MonoBehaviour {

	Text _myText;

	// Use this for initialization
	void Start () {
		_myText = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		_myText.text = "The Best Score is: " + GameManager_script.instance.bestScore;
		
	}
}
