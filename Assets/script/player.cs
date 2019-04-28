using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public int level;
    public string name;
    public int age;
    public string gender;

    // Use this for initialization
    public void saveplayer()
    {
        save.SavePlayer(this);
    }

    public void LoadPlayer()
    {
      
    }
}
