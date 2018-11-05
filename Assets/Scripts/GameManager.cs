using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject ball;
	public static int playerOneScore;
	public static int playerTwoScore;
	// Use this for initialization
	void Start() {
		ball = GameObject.FindGameObjectWithTag("Ball");
		playerOneScore = 0;
		playerTwoScore = 0;
	}

	// Update is called once per frame
	void Update() {

	}
	
	public static void Score(string wall)
	{
		Debug.Log("Wallside: " + wall);
		if(wall == "LeftWall")
		{
			playerOneScore++;
			Debug.Log("Player 1:" + playerOneScore);
		}
		if(wall == "RightWall")
		{
			playerTwoScore++;
			Debug.Log("player 2: " + playerTwoScore);
		}
	}
	private void OnGUI()
	{
		
	}
}
