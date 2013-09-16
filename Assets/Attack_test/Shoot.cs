using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public float damage = 10f;
	
	private GameObject enemy;
	private bool shoot;
	private float timer = 0f;

	void Start () {
	}
	
	void Update () {
		enemy = GetComponent<Sight>().enemy;
		shoot = GetComponent<Sight>().shoot;
		timer += Time.deltaTime;
		if (shoot && timer >= 1f) {
			Messenger<GameObject,float>.Broadcast("take damage", enemy, damage);
			timer = 0;
		}
	}
}
