using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject apple, banana, orange, applePlace, bananaPlace, oranPlace;
    Vector2 appleInitiallPos, bananaInitiallPos, oranInitiallPos;
    public GameObject Next_level;

    bool appleCorrect, orangeCorrect, bananaCorrect;
    // Use this for initialization
    void Start () {

        bananaInitiallPos = banana.transform.position;
        appleInitiallPos = apple.transform.position;
        oranInitiallPos = orange.transform.position;
    }
    public void Dragapple()
    {
        apple.transform.position = Input.mousePosition;
    }

    public void Dragorange()
    {
        orange.transform.position = Input.mousePosition;
    }

    public void DragBanana()
    {
        banana.transform.position = Input.mousePosition;
    }
    public void Dropapple()
    {
        float Distance = Vector2.Distance(apple.transform.position, applePlace.transform.position);
        if (Distance < 50)
        {
            apple.transform.position =applePlace.transform.position;
            appleCorrect = true;
        }
        else
        {
            apple.transform.position = appleInitiallPos;

        }
    }
    public void Droporange()
    {
        float Distance = Vector3.Distance(orange.transform.position, oranPlace.transform.position);
        if (Distance < 50)
        {
            orange.transform.position = oranPlace.transform.position;
            orangeCorrect = true;
        }
        else
        {
            orange.transform.position = oranInitiallPos;

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
        if (appleCorrect && orangeCorrect && bananaCorrect)
        {


            Next_level.SetActive(true);
        }

    }
}
