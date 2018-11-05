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
		}
		if(wall == "RightWall")
		{
			playerTwoScore++;
		}
	}
	private void OnGUI()
	{
		GUI.skin = layout;
		GUI.Label(new Rect(10, 50, 100, 100),"" + playerOneScore);
		GUI.Label(new Rect(Screen.width - 25, 50, 100, 100), "" + playerTwoScore);
		if(playerOneScore == 5)
		{
			GUI.Label(new Rect(Screen.width / 2, 300, 100, 100), "Player One Wins!!!!!");
			ball.SendMessage("RestartGame", null);
			playerOneScore = 0;
			playerTwoScore = 0;
		}
		if(playerTwoScore == 5)
		{
			GUI.Label(new Rect(Screen.width / 2, 50, 100, 100), "Player Two Wins!!!!!");
			ball.SendMessage("RestartGame", null);
			playerOneScore = 0;
			playerTwoScore = 0;
		}
		if(playerOneScore == 5)
		{
			
		}
		if(playerTwoScore == 5)
		{
			
		}
	}
}
