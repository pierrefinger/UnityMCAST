using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class execise : MonoBehaviour {

    int number = 500;


	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow Pressed");
            number++;
            print(number);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow pressed");
            number--;
            print(number);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Left Arrow pressed");
            number -= 10;
            print(number);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Right Arrow pressed");
            number += 10;
            print(number);
        }
        if (number == 0 || number == 1000)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
