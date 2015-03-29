﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {

	public Text guessText;

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		max = max +1;
		guessText.text = guess.ToString();
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick number in your head, but don't tell me");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower then " + guess);
		print ("Up = higher, down = lower, return = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			GuessHigher();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			GuessLower();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			GuessCorrect();
		}
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	public void GuessCorrect(){
		print("I won!");
		StartGame();
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower then " + guess);
		print ("Up = higher, down = lower, return = equal");
		guessText.text = guess.ToString();
	}
}
