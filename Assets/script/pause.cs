using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour {

    public GameObject pausePanel;

   public void PauseGame()
    {
        pausePanel.SetActive(true);

    }
   public void ResumeGame()
    {

        pausePanel.SetActive(false);
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
