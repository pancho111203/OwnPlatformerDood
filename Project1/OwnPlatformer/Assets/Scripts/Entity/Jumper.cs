using UnityEngine;
using System.Collections;

public class Jumper : MonoBehaviour {
	public float force = 1500.0f;


	// NOT WORKING

	void OnCollisionEnter (Collision collision){
		Debug.Log(collision.gameObject.tag+"ssdsd");
		if(collision.gameObject.tag == "Player"){
			Debug.Log("TSER");
			Rigidbody2D rig =  collision.gameObject.GetComponent<Rigidbody2D>();
			rig.AddForce(Vector3.up*force);
		}
	}
	void OnTriggerEnter (Collider collision){
		Debug.Log(collision.gameObject.tag+"ssdsd");
		if(collision.gameObject.tag == "Player"){
			Debug.Log("TSER");
			Rigidbody2D rig =  collision.gameObject.GetComponent<Rigidbody2D>();
			rig.AddForce(Vector3.up*force);
		}
	}
}
