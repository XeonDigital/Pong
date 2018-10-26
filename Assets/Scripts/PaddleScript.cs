using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {
	public Rigidbody2D rBody;
	public float speed;
	// Use this for initialization
	void Start () {
		//takes the component 
		rBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		//takes the input of the pressed key (1 = up/right -1 = down/left)
		float vert = Input.GetAxis("Vertical");
		//used for debugging
		Debug.Log("x: " + vert);
		//creates a 2d vector 
		Vector2 movement = new Vector2(0,vert);
		rBody.velocity = movement * speed;
	}
}
