using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelunlocked : MonoBehaviour
{
    public static int level = 1;
    public GameObject[] levelUnlocked;
    public int max_level;
   


    // Start is called before the first frame update
    void Start()

    {
        level = PlayerPrefs.GetInt("level", level);

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < max_level; i++) 
        {
            {


                if (i <= level)
                {
                    levelUnlocked[i].SetActive(false);
                    Debug.Log("" + level);
                }
                else
                {
                    levelUnlocked[i].SetActive(true);
                    Debug.Log("" + level);
                }
            }

        }
    }  

    public static void NextLevel()
    {
        
            level += 1;
            PlayerPrefs.SetInt("level", level);
        
    }
    public void Reset()
    {
        level = 1;
        PlayerPrefs.SetInt("level", level);

    }
    public void add_level()
    {
        NextLevel();
        Application.LoadLevel("main");
    }
}
 
