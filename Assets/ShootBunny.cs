using UnityEngine;
using System.Collections;

public class ShootBunny : MonoBehaviour
{
	
	GameObject target;
	public GameObject bullet;
	
	// Use this for initialization
	void Start ()
	{
		
		target = GameObject.FindGameObjectWithTag ("Bunny");
	}
	
	public float spawnTime;
	private float timer;
	
	public void Boom() {
		Destroy(this,0);	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.LookAt (target.rigidbody.position);
			
		timer += Time.fixedDeltaTime;
		//Debug.LogWarning (timer);
		if (timer > spawnTime) {
			
			
			Ray ray = new Ray (transform.position, transform.forward);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				
				if (hit.collider == target.collider) {
					timer = 0;
					var shot = Instantiate (bullet, this.transform.position, Quaternion.identity) as GameObject;
					shot.SetActive (true);
					shot.rigidbody.AddForce (transform.forward * 5000);
				}    
					
			}
			
			
			
			
		}
	}
}
