using UnityEngine;
using System.Collections;

public class RTSClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	bool hasBunny= false;
	
	
	
	// Update is called once per frame
	void Update () {
	  if (Input.GetMouseButtonDown(0)) {
			
			
			
			
     	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
     	RaycastHit hit;
     	Debug.Log("Clicked");
     	if (Physics.Raycast(ray,out hit)) {
				
				if (hit.collider.name == "BunnySpawner") {
					hasBunny = !hasBunny;	
				} else if (hasBunny) {
					var shot = Instantiate(GameObject.Find("Capsule"),hit.point+Vector3.up*10, Quaternion.identity);
					//shot.rigidbody.AddForce(transform.forward * 1000);
					
				} else  if (hit.collider.tag == "Bunny") {
					
					hit.collider.rigidbody.AddForce(Vector3.up * 100);
					
				} else  {
					GameObject.Find("Bunny").transform.position = hit.point;	
					GameObject.Find("Bunny").rigidbody.velocity =Vector3.back;
				}
				/*Vector3 targetPoint = ray.GetPoint(hitdist);
				destinationPosition = ray.GetPoint(hitdist);
				Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
				myTransform.rotation = targetRotation;*/
			}
     	
     }
         
	}
}
