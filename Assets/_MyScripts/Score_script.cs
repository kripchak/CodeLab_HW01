using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_script : MonoBehaviour {

	Text _myText;

	// Use this for initialization
	void Start () {
		_myText = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		_myText.text = "Score: " + GameManager_script.instance.score;
		
	}
}
