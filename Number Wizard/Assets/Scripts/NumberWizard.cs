using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //Creates 2 integer variables
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        print("Welcome To Number Wizard");
        print("Please think of a number from " + min + " to " + max + "!");
        NextGuess();
    }

    void NextGuess()
    {
        print("Is the number bigger or smaller than " + guess + "?");
        print("UP: Bigger DOWN: Smaller RETURN: Equal");
    }

    //Prints these once
    void Start () {
        StartGame();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
        }
         else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            NextGuess();
        }
         else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("YOU WON!");
            print("Press (P) to Play Again or press (Q) to Quit");


        }
             if (Input.GetKeyDown(KeyCode.P))
                {
                    StartGame();
                }
             else if (Input.GetKeyDown(KeyCode.Q))
                {
            UnityEditor.EditorApplication.isPlaying = false;
            }
    }
}
