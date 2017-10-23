using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisionBreakGame : MonoBehaviour {

    public Text myText;

    private enum States
    {
        cell, sheets_0, mirror, lock_0, cell_mirror, lock_1, sheets_1, freedom
    };

    States myState;

    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape." +
                "There are some dirty sheets on my bed, a mirror on the wall, " +
                "and the door is locked from the outside.\n\n" +
                "Press S to view Sheets, M to view Mirror and L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }
    void Sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. Surely it's " +
                        "time somebody changed them. The pleasures of prison life " +
                        "I guess!\n\n" + "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void Mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
                        "some dirty sheets on the bed, a mirror , " +
                        "and that pesky door is still there, and firmly locked!\n\n" +
                        "Press R to go back Cell or T to Take the Mirror";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
    }
    void Lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the " +
                        "combination is. You wish you could somehow see where the dirty " +
                        "fingerprints were, maybe that would help.\n\n" +
                        "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void Cell_Mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
                        "some dirty sheets on the bed, a mark where the mirror was, " +
                        "and that pesky door is still there, and firmly locked!\n\n" +
                        "Press S to view Sheets, or L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look" +
                        "any better.\n\n Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }
    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round " +
                        "so you can see the lock. You can just make out fingerprints around " +
                        "the buttons. You press the dirty buttons, and hear a click.\n\n" +
                        "Press O to Open, or R to Return to your cell";
        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.freedom;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }
    void Freedom()
    {
        myText.text = "YOU ARE FREE!! Press P to Play again.";

    }

    // Use this for initialization
    void Start () {

        myState = States.cell;

	}
	
	// Update is called once per frame
	void Update () {
        if (myState == States.cell)
        {
            Cell();
        }
        if (myState == States.sheets_0)
        {
            Sheets_0();
        }
        if (myState == States.mirror)
        {
            Mirror();
        }
        if (myState == States.lock_0)
        {
            Lock_0();
        }
        if (myState == States.cell_mirror)
        {
            Cell_Mirror();
        }
        if (myState == States.sheets_1)
        {
            Sheets_1();
        }
        if (myState == States.lock_1)
        {
            Lock_1();
        }
        if (myState == States.freedom)
        {
            Freedom();
        }



    }
}
