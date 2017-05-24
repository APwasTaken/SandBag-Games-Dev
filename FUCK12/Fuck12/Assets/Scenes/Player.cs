using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Animator animator;

	//players health cant you fucking read
	public float hp = 0.0f;

	//players posistion learn to read
	public float xAxis = 0.0f;
	public float yAxis = 0.0f;

	// Use this for initialization
	void Start () {
		//The players posistion on the x and y axis
		 xAxis = Input.GetAxis("Horizontal");
		 yAxis = Input.GetAxis("Vertical");

		//initciatiating the animator
		animator = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update () {
		
	}
	//the method to trigger the death animation;
	void Death() {
		//if the players hp is less than or equal to 0 die
		if (hp <= 0){
			//setting the trigger in animator to die
			animator.SetTrigger("Die");
		}
		else {
			Debug.Log("Good Health", this);
		}
	}
}
