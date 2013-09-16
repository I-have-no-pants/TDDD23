using UnityEngine;
using System.Collections;

public class AddTurret : MonoBehaviour {
	
	public GameObject turret;
	public GameObject plate;
	
	// Use this for initialization
	void Start () {
		
			/*
		var shot = Instantiate (turret, this.transform.position, Quaternion.identity) as GameObject;
		shot.SetActive (true);
		shot.transform.parent = this.gameObject.transform;*/
		
		{
		var shot = Instantiate (plate, this.transform.position, Quaternion.identity) as GameObject;
		shot.SetActive (true);
		shot.transform.parent = this.gameObject.transform;
			
		
		var shot2 = Instantiate (turret, shot.transform.position+Vector3.right+Vector3.up*0.7f, Quaternion.identity) as GameObject;
		shot2.SetActive (true);
		shot2.transform.parent = shot.transform;
			
			var shot3 = Instantiate (turret, shot.transform.position-Vector3.right+Vector3.up*0.7f, Quaternion.identity) as GameObject;
		shot3.SetActive (true);
		shot3.transform.parent = shot.transform;
		
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
