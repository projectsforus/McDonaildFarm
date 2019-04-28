using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {
      
    public GameObject completegame;
    

	// Use this for initialization
	void Start () {

        completegame.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

       

    }
    public void RestartGame()
    {
        SceneManager.LoadScene("level 1");

    }
}
