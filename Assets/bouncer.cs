using UnityEngine;
using System.Collections;

public class bouncer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Destroy(this.gameObject,1);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnTriggerEnter (Collider other) {
		//other.SendMessage("Boom");
		if (other.rigidbody != null) {
			
			//other.renderer.material.color = Color.red;
			//other.rigidbody.AddForce(Vector3.up * 1000);
		} else {
			//Destroy(other.gameObject,0);
		}
		
	}
}
