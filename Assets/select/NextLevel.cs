using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour

{
    public GameObject Next_level;
    public int max_level;
    public string num_level;
    private  GameObject panel;
    public static int thelevel;
    public int t;
    bool strwaberryCorrect , pargmentCorrect, bananaCorrect;
    // Start is called before the first frame update
    void Start()
    {
        bool strwaberryCorrect, pargmentCorrect, bananaCorrect = false;
   
        thelevel = PlayerPrefs.GetInt("the level", thelevel);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i = 1; i < max_level; i++)
        {
            if (strwaberryCorrect && pargmentCorrect && bananaCorrect && levelunlocked.level== i)
            {
                Debug.Log("You Win!");
                Next_level.SetActive(true);
            }
        }
        
    }
}
