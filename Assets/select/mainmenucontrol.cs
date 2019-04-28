using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManuControlScript : MonoBehaviour
{

    public Button level02Button, level03Button;
    int levelPassed;

    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
        }
    }

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    
}






