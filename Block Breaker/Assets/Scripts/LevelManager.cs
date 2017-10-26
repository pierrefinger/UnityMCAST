using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string levelname)
    {
        print("Loading level " + levelname);
        SceneManager.LoadScene(levelname);
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
