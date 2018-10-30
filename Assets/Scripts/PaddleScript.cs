using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	//proproties for 
	public float xMax, xMin, yMax, yMin;
}

public class PaddleScript : MonoBehaviour {

	public Rigidbody2D rBody;
	public float speed;
	public Boundary boundary;
	public string input;
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
		float vert = Input.GetAxis(input);
		//used for debugging
		Debug.Log("x: " + vert);
		//creates a 2d vector 
		Vector2 movement = new Vector2(0,vert);
		//moves the player
		rBody.velocity = movement * speed;
		rBody.position = new Vector2(
			Mathf.Clamp(rBody.position.x, boundary.xMin, boundary.xMax),  // Restrict the x position to xMin and xMax
			Mathf.Clamp(rBody.position.y, boundary.yMin, boundary.yMax)); // Restrict the y position to yMin and yMax
	}
}
