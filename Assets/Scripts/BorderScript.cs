using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour {
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("asd");
		if (other.CompareTag("Ball"))
		{
			name = this.gameObject.name;
			GameManager.Score(name);
			other.SendMessage("RestartGame", null);
		}
	}
}
