﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumber : MonoBehaviour {


    Text text;
    int sceneIndex=1;
    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
	
	// Update is called once per frame
	void Update () {
       
        sceneIndex.ToString();
        text.text = "Level " + sceneIndex;

    }
}
