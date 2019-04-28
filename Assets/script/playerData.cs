using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class playerData : MonoBehaviour {


    public int level;
    public string name;
    public int age;
    public string gender;

    public playerData(player player)
    {
       level= player.level;
        name = player.name;
        age = player.age;
        gender = player.gender;
    }

   
    
   


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
