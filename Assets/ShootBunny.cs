using UnityEngine;
using System.Collections;

public class ShootBunny : MonoBehaviour
{
	
	GameObject target;
	public GameObject bullet;
	
	Quaternion start;
	
	public float length;
	
	public bool lockAngle;
	
	
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
		
		if (lockAngle) {
			transform.Rotate(start.eulerAngles.x-transform.eulerAngles.x, 0, start.eulerAngles.z-transform.eulerAngles.z);
		}
			
			Debug.DrawRay(transform.position+Vector3.forward*length,-transform.right);
			
		timer += Time.fixedDeltaTime;
		//Debug.LogWarning (timer);
		if (timer > spawnTime) {
			
			Debug.LogWarning("Fire");
			
			Ray ray = new Ray (transform.position+Vector3.forward*length, -transform.right);
			RaycastHit hit;
			Physics.Raycast (ray, out hit);
			
			
			if (Physics.Raycast (ray, out hit)) {
				
				if (hit.collider == target.collider) {
					timer = 0;
					var shot = Instantiate (bullet, this.transform.position, Quaternion.identity) as GameObject;
					shot.SetActive (true);
					shot.rigidbody.AddForce ( -transform.right * 5000);
				}    
					
			}
			
			
			
			
		}
	}
}
