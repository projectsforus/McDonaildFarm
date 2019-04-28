using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager2 : MonoBehaviour {

    public GameObject strwaberry,banana, pargment, strwaberryPlace, bananaPlace, pargmentPlace;
    Vector2 strwaberryInitiallPos, bananaInitiallPos, pargmentInitiallPos;
    public GameObject Next_level;

    bool strwaberryCorrect, pargmentCorrect, bananaCorrect;
	// Use this for initialization
	void Start () {
        
        bananaInitiallPos = banana.transform.position;
        strwaberryInitiallPos = strwaberry.transform.position;
        pargmentInitiallPos = pargment.transform.position;
      
        

    }
    public void Dragstrwaberry()
    {
        strwaberry.transform.position = Input.mousePosition;
    }

    public void Dragpargment()
    {
        pargment.transform.position = Input.mousePosition;
    }

    public void DragBanana()
    {
        banana.transform.position = Input.mousePosition;
    }

    public void Dropstrwaberry()
    {
        float Distance = Vector2.Distance(strwaberry.transform.position, strwaberryPlace.transform.position);
        if (Distance < 50)
        {
            strwaberry.transform.position = strwaberryPlace.transform.position;
            strwaberryCorrect = true;
        }
        else
        {
            strwaberry.transform.position = strwaberryInitiallPos;

        }
    }
    public void Droppargment()
    {
        float Distance = Vector3.Distance(pargment.transform.position, pargmentPlace.transform.position);
        if (Distance < 50)
        {
            pargment.transform.position = pargmentPlace.transform.position;
            pargmentCorrect = true;
        }
        else
        {
            pargment.transform.position = pargmentInitiallPos;

        }

    }
    public void DropBanana()
    {
        float Distance = Vector3.Distance(banana.transform.position, bananaPlace.transform.position);
        if (Distance < 50)
        {
            banana.transform.position = bananaPlace.transform.position;
            bananaCorrect = true;
        }
        else
        {
            banana.transform.position = bananaInitiallPos;

        }

    }

    // Update is called once per frame
    void Update () {
        if (strwaberryCorrect && pargmentCorrect && bananaCorrect)
        {
            
            
            Next_level.SetActive(true);
        }


    }
}
