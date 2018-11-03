using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	GameObject theBall;
	// Use this for initialization
	void Start () {
		theBall = GameObject.FindGameObjectWithTag("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
