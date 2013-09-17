using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	public float health = 100f;
	public bool dead = false;
	
	private string team;
	
	void Start () {
		Messenger<GameObject,float>.AddListener("take damage", takeDamage);
		team = gameObject.tag;
	}
	
	void Update () {
		if (health < 0) {
			dead = true;
			enabled = false;
			die ();
		}
		
	}
	
	void OnGUI () {
		if (team == "Team1") {
			GUI.Box(new Rect(10,10, 100, 20), "");
			GUI.Label(new Rect(20,10, 180, 20), health + " / " + "100");
		} else if (team == "Team2") {
			GUI.Box(new Rect(Screen.width - 110,10, 100, 20), "");
			GUI.Label(new Rect(Screen.width - 100,10, 180, 20), health + " / " + "100");
		}
	}
	
	public void takeDamage(GameObject target, float damage) {
		
		if (gameObject == target) {
			health -= damage;
		}
	}
	
	void die() {
		gameObject.SetActive(false);
		Destroy(this.gameObject, 0.5f);
	}
}
