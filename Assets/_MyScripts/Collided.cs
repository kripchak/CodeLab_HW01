using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour {


	private Collider shipCollider;

	public KeyCode blowUp = KeyCode.Return;

	// Use this for initialization
	void Start () {
		shipCollider = GetComponent<CapsuleCollider>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (blowUp)) {
			Destroy (gameObject);
		
		}
		
	}


	void OnTriggerEnter ( )
	{
		GameManager_script.instance.score += 1;


			Destroy(gameObject);
		Debug.Log ("Collision!");
	}

}
