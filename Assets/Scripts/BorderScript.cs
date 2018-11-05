using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour {
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("Wall Name: " + this.gameObject.name);
		if (other.collider.CompareTag("Ball"))
		{
			name = this.gameObject.name;
			GameManager.Score(name);
		}
	}
}
