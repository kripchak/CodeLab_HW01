using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {

	private float startTime = 0.0f;
	private float deltaTiame = 0.0f;
	Text _myText;

	// Use this for initialization
	void Start () {

		_myText = GetComponent<Text> ();
		startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {

		_myText.color = new Color(1f,Mathf.Abs(Mathf.Sin(Time.time)) ,Mathf.Abs(Mathf.Sin(Time.time)));

	}
}
