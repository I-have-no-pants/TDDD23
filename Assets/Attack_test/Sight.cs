using UnityEngine;
using System.Collections;

public class Sight : MonoBehaviour {
	
	public GameObject enemy = null;
	public bool shoot = false;
	public string enemyTeam;
	
	private string team;
	
	void Start () {
		team = gameObject.tag;
		if (team == "Team1")
			enemyTeam = "Team2";
		else if (team == "Team2")
			enemyTeam = "Team1";
	}
	
	void Update () {
		if (enemy != null &&enemy.GetComponent<Health>() != null && enemy.GetComponent<Health>().dead) {
			enemy = null;
			shoot = false;
			Debug.Log("My target is dead!");
		}
	}
	
	void OnTriggerStay (Collider other) {
		if (!other.isTrigger) {
			if (other.tag == enemyTeam && enemy == null && other.gameObject.GetComponent<Health>() != null && !other.gameObject.GetComponent<Health>().dead) {
				enemy = other.gameObject;
				shoot = true;
			}
		}
	}
}
