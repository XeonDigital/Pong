using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject ball;
	public static int playerOneScore;
	public static int playerTwoScore;
	public GUISkin layout;
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
		GUI.skin = layout;
		Debug.Log("screenwidth" + Screen.width / 2);
		GUI.Label(new Rect(10, 50, 100, 100),"" + playerOneScore);
		GUI.Label(new Rect(Screen.width - 25, 50, 100, 100), "" + playerTwoScore);
		if(playerOneScore == 1)
		{
			GUI.Label(new Rect(Screen.width / 2, 125, 100, 100), "Player One Wins!!!!!");
			Invoke
		}
		if(playerTwoScore == 10)
		{
			GUI.Label(new Rect(Screen.width / 2, 150, 100, 100), "Player Two Wins!!!!!");
		}
	}
}
