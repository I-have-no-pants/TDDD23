using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public float spawnTime;
	public GameObject prefab;
	
	private float timer;
	private GameObject attacker;
	
	void Start () {
	
	}
	
	void Update () {
		timer += Time.deltaTime;
		if (timer > spawnTime) {
			timer = 0;
			if (gameObject.tag == "Team1") {
				attacker = Instantiate(prefab,transform.position+Vector3.right*2, Quaternion.identity) as GameObject;
				attacker.renderer.material.color = Color.blue;
			} else {
				attacker = Instantiate(prefab,transform.position+Vector3.left*2, Quaternion.identity) as GameObject;
				attacker.renderer.material.color = Color.red;
			}
			attacker.SetActive (true);
		}
	}
}
