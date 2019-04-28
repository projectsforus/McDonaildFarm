using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FirebaseLevel3 : MonoBehaviour
{ // InputField  ProgressIdication, currentLevel;


    DatabaseReference reference;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://mcdonailds.firebaseio.com/");

        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;

        saveDataAsJson();

        // 
    }






    private string saveDataAsJson()
    {
        patients patients = new patients(PlayerPrefs.GetString("username"), PlayerPrefs.GetString("password"), PlayerPrefs.GetString("age"), PlayerPrefs.GetString("gender"), "3");
        string json = JsonUtility.ToJson(patients);



        reference.Child("patients").Child(PlayerPrefs.GetString("userid")).SetRawJsonValueAsync(json);

        return "Save data to firebase Done.";
    }









}







