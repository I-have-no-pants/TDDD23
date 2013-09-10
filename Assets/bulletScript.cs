using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {
	
	public GameObject expl;
	
	// Use this for initialization
	void Start () {
	
	 Invoke("boom", 1);
	}
	
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Bunny")
			boom();
		
	}
		
	void boom() {
		var shot = Instantiate(expl,this.transform.position, Quaternion.identity) as GameObject;
		shot.SetActive(true);
			
		Destroy (this.gameObject);
	}
	
	/*
	public float spawnTime = 1;
	private float timer;
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.fixedDeltaTime;
		Debug.LogWarning (timer);
		if (timer > spawnTime) {
			
			DestroyObject(this);
		}
	}
			
	*/
}
