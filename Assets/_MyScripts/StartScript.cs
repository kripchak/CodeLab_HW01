﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {

	Text _myText;

	// Use this for initialization
	void Start () {

		_myText = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		_myText.color = new Color(1f,Mathf.Abs(Mathf.Sin(Time.time)) ,Mathf.Abs(Mathf.Sin(Time.time)));

	}
}
