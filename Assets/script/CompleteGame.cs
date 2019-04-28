using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CompleteGame : MonoBehaviour
{

    
    public GameObject completeGamePanel, levelSign;
    int sceneIndex, levelPassed;
     bool strwaberryCorrect , pargmentCorrect, bananaCorrect;
    // Use this for initialization
    void Start()
    {
       
       

         levelSign = GameObject.Find("LevelNumber");
         completeGamePanel = GameObject.Find("CompleteGame");
      

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    public void youWin()
    {

        
        if (sceneIndex == 4)
            Invoke("loadMainMenu", 1f);
        else
        {
            if (levelPassed < sceneIndex && strwaberryCorrect && pargmentCorrect && bananaCorrect)
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            completeGamePanel.gameObject.SetActive(true);
            Invoke("loadNextLevel", 1f);
        }
    }
   public void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void RestartGame()
        {
            SceneManager.LoadScene(sceneIndex);

        }
    } 