using UnityEngine;
using System.Collections;

public class ShootBunny : MonoBehaviour
{
	
	GameObject target;
	public GameObject bullet;
	
	Quaternion start;
	
	public float length;
	
	
	// Use this for initialization
	void Start ()
	{
		
		target = GameObject.FindGameObjectWithTag ("Bunny");
		start = transform.rotation;
	}
	
	public float spawnTime;
	private float timer;
	
	public void Boom() {
		Destroy(this,0);	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		transform.LookAt (target.rigidbody.position);
		transform.Rotate(start.eulerAngles);
		
		timer += Time.fixedDeltaTime;
		//Debug.LogWarning (timer);
		if (timer > spawnTime) {
			
			Debug.LogWarning("Fire");
			
			
			Ray ray = new Ray (transform.position+Vector3.forward*length, transform.rotation.eulerAngles);
			RaycastHit hit;
			Physics.Raycast (ray, out hit);
			//if (Physics.Raycast (ray, out hit)) {
				
				//if (hit.collider == target.collider) {
					timer = 0;
					var shot = Instantiate (bullet, this.transform.position, Quaternion.identity) as GameObject;
					shot.SetActive (true);
					//shot.rigidbody.AddForce ( transform.rotation.transform.forward.normalized * 5000);
				//}    
					
			//}
			
			
			
			
		}
	}
}
