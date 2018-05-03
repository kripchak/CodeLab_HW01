using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipExplosion : MonoBehaviour {


	private Collider shipCollider;
	private Vector3 place;
	private AudioClip chosenAudio;
	private int randomNumber;
	public GameObject explosion;
	public AudioClip explodeAudio1, explodeAudio2;

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


	void OnTriggerEnter (Collider other )
	{
		if( other.gameObject.tag == "Player"){
			GameManager_script.instance.score += 1;
			place = gameObject.transform.position;
			var GameObject = Instantiate (explosion, this.transform.position, this.transform.rotation);
			AudioSource audio = GetComponent<AudioSource> ();
			Destroy(gameObject);
			audio.Play ();

				
			Debug.Log ("Collision!");
		}	
	}


}
