using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour {
	public GameManager gameManager;
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("Wall Name: " + this.gameObject.name);
		if (other.collider.CompareTag("Ball"))
		{
			if(this.gameObject.name == "RightWall")
			{
				other.gameObject.SendMessage("")
			}
			if(this.gameObject.name == "LeftWall")
			{
				this.GetComponent<GameManager>().LeftWallHit();
			}
		}
	}
}
