using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	private float rndDirection;
	private Rigidbody2D rbody;
	private Vector2 movement;
	public float speed;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D>();
		rndDirection = Random.Range(0, 2);
		if (rndDirection == 0){
			movement = new Vector2(1, 0);
			rbody.velocity = movement * speed;
		}
		if (rndDirection == 1){
			movement = new Vector2(-1, 0);
			rbody.velocity = movement * speed;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
