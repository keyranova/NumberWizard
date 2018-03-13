using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () {
	    StartGame();
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print ("up arrow was pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print ("down arrow was pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won");
		}
	}

	void StartGame() {
		max = max + 1;

		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me!");

		print("The highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);

		print("Is the number higher or lower than " + guess + "?");
		print("Up = higher, down = lower, return = equal");
	}

	void NextGuess() {
		guess = (max + min) / 2;
		print("Higher or lower than " + guess + "?");
		print("Up = higher, down = lower, return = equal");
	}
}
