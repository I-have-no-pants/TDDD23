using UnityEngine;
using System.Collections;

public class FactoryScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public GameObject spawn;
	public float spawnTime;
	private float timer;
	
	int n=0;
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.fixedDeltaTime;
		//.LogWarning (timer);
		if (n < 10 && timer > spawnTime) {
			
			
			timer = 0;
			n++;
			GameObject shot = Instantiate(spawn,transform.position+Vector3.up*2, Quaternion.identity) as GameObject;
			shot.SetActive (true);
		}
		
		
	}
}
