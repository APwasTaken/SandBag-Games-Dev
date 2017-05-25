using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {
	Rigidbody2D rigBod;
	public float hp = 0.0f;
	// This handles player collision
	void OnTriggerEnter2D(Collider2D other) {
			  // If enemy collides with the player, subtract 1 from player hp
				// as well as destroy this enemy game object
        if (other.CompareTag("Player")) {
            Player.hp -= 1;
						Destroy(gameObject);
						// Debug.Log(Player.hp, this);
				}
  }
	// Enemy starts with 2 hp
	void Start () {
		hp = 2;
		rigBod = GetComponent<Rigidbody2D>();
		rigBod.velocity = new Vector2(-3,0);
	}

	// Update is called once per frame
	void Update () {

	}
}
