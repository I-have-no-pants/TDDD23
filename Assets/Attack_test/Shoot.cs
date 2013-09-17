using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public float damage = 10f;
	public float shootDelay = 1f;
	
	private GameObject enemy;
	private bool shoot;
	private float timer = 0f;

	void Start () {
	}
	
	void Update () {
		enemy = GetComponent<Sight>().enemy;
		shoot = GetComponent<Sight>().shoot;
		timer += Time.deltaTime;
		if (shoot && timer >= shootDelay) {
			enemy.GetComponent<Health>().takeDamage(enemy,damage);
			timer = 0;
		}
	}
}
