using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevevlManager3 : MonoBehaviour {

    public GameObject pineapple,manga,pear, pinplace, mangaPlace, pearplace;
    Vector2 pinappleInitiallPos, mangaInitiallPos, pearInitiallPos;

    public GameObject Next_level;
    bool pinappleCorrect, mangaCorrect, pearCorrect;

    // Use this for initialization
    void Start () {

        pinappleInitiallPos = pineapple.transform.position;
        mangaInitiallPos = manga.transform.position;
        pearInitiallPos = pear.transform.position;

    }


    public void Dragpinapple()
    {
        pineapple.transform.position = Input.mousePosition;
    }

    public void Dragmanga()
    {
        manga.transform.position = Input.mousePosition;
    }

    public void Dragpear()
    {
        pear.transform.position = Input.mousePosition;
    }

    public void Droppinapple()
    {
        float Distance = Vector3.Distance(pineapple.transform.position, pinplace.transform.position);
        if (Distance < 50)
        {
            pineapple.transform.position = pinplace.transform.position;
            pinappleCorrect = true;
        }
        else
        {
            pineapple.transform.position = pinappleInitiallPos;

        }
    }
    public void Dropmanga()
    {
        float Distance = Vector3.Distance(manga.transform.position, mangaPlace.transform.position);
        if (Distance < 50)
        {
            manga.transform.position = mangaPlace.transform.position;
            mangaCorrect = true;
        }
        else
        {
            manga.transform.position = mangaInitiallPos;

        }

    }
    public void Droppear()
    {
        float Distance = Vector3.Distance(pear.transform.position, pearplace.transform.position);
        if (Distance < 50)
        {
            pear.transform.position = pearplace.transform.position;
            pearCorrect = true;
        }
        else
        {
            pear.transform.position = pearInitiallPos;

        }

    }
    // Update is called once per frame
    void Update () {

        if (pinappleCorrect && mangaCorrect && pearCorrect)
        {


            Next_level.SetActive(true);
        }

    }
}
