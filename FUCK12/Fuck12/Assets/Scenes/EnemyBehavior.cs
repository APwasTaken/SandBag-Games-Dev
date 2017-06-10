using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

	//Rigidbody2D rigBod;                               // Used later in the Start() function
	public float hp = 0.0f;	                          // This allows you to set the hp of the enemy in Unity

	// This handles player collision
	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Player.hp -= 1;                        // If enemy collides with the player, subtract 1 from player hp
						Destroy(gameObject);  								 // as well as destroy this enemy game object
						//Debug.Log(Player.hp, this);            // This shows that the players hp is being changed when colliding with enemy object
				}
  }

	// Initialize Enemy properties
	void Start () {
		hp = 2;                                         // Enemy starts with 2 hp
		//rigBod = GetComponent<Rigidbody2D>();		        // Initialize(sort of) the enemy to a Rigidbody2D object
		//rigBod.velocity = new Vector2(-3,0);					  // Enemy moves in the negative x-axis direction, we will change to negative y-axis direction
	}

	// Update is called once per frame
	void Update () {

	}
}
