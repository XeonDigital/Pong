using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	private float rndDirection;
	public Rigidbody2D rbody;
	private Vector2 movement;
	public float speed;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D>();
		Invoke("BallStart", 2);
	}
	void BallStart()
	{
		rndDirection = Random.Range(0, 2);
		if (rndDirection == 0)
		{
			movement = new Vector2(1, 0);
			rbody.velocity = movement * speed;
		}
		if (rndDirection == 1)
		{
			movement = new Vector2(-1, 0);
			rbody.velocity = movement * speed;
		}
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.CompareTag("Player"))
		{
			Debug.Log("collided with player");
			movement.x = rbody.velocity.x;
			movement.y = (rbody.velocity.y / 2) + (other.collider.attachedRigidbody.velocity.y / 3);
			rbody.velocity = movement;
		}
	}
	void ResetBall()
	{
		rbody.velocity = Vector2.zero;
		rbody.position = Vector2.zero;
	}
	void Score()
	{
		
	}
}
