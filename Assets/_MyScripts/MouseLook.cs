using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {


	public Vector3 hitLocation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Vector3 mouseScreenPos = Input.mousePosition;
			mouseScreenPos.z = 0;
			Ray mouseRay = Camera.main.ScreenPointToRay (mouseScreenPos);
			RaycastHit hitInfo;
			Debug.Log (mouseScreenPos);

			if (Physics.Raycast (mouseRay, out hitInfo)) {
				hitLocation = hitInfo.point;
//				Debug.Log (hitLocation);
//				Debug.Log ("hi");

				//Debug.Log(hitInfo.collider);
			}
		}
	}
}


