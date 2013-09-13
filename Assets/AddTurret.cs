using UnityEngine;
using System.Collections;

public class AddTurret : MonoBehaviour {
	
	public GameObject turret;
	
	// Use this for initialization
	void Start () {
		var shot = Instantiate (turret, this.transform.position, Quaternion.identity) as GameObject;
		shot.SetActive (true);
		shot.transform.parent = this.gameObject.transform;
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
