using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float speed = 1f;
	
	private bool shoot;
	private string team;
	private float health;
	
	void Start () {
		team = gameObject.tag;
	}
	
	void Update () {
		shoot = GetComponent<Sight>().shoot;
		health = GetComponent<Health>().health;
		if (!shoot) {
			if (team == "Team1")
				transform.Translate(Vector3.right * speed * Time.deltaTime);
			else
				transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
	}
}
