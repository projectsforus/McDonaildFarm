using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FirebaseScript : MonoBehaviour
{
    // InputField  ProgressIdication, currentLevel;
    public InputField usernameInput, passowrdInput, AgeInput, Gender;
    public InputField usernameInputLogin, passowrdInputLogin;
    public Text logintxt, regtext;
    public GameObject Reg, Log;
    DatabaseReference reference;

    // Start is called before the first frame update
    void Start()
    {
        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://mcdonailds.firebaseio.com/");

        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;



        // 
    }



    public void OnClickRigester()
    {
        PlayerPrefs.SetString("username", usernameInput.text.ToString());
        PlayerPrefs.SetString("password", passowrdInput.text.ToString());
        PlayerPrefs.SetString("age", AgeInput.text.ToString());
        PlayerPrefs.SetString("gender", Gender.text.ToString());

        PlayerPrefs.SetString("userid", usernameInput.text + passowrdInput.text + AgeInput.text + Gender.text);
        PlayerPrefs.Save();
        saveDataAsJson();
        regtext.text = "success";
        SceneManager.LoadScene("selectLevel");
    }

    public void OnClickLogin()
    {

        if(usernameInputLogin.text.ToString()==PlayerPrefs.GetString("username") && passowrdInputLogin.text.ToString() == PlayerPrefs.GetString("password"))
        {
            logintxt.text = "success";
            SceneManager.LoadScene("selectLevel");
        }
        else
        {
            logintxt.text = "failure";
        }
        //retrieveData();

    }

    public void OnClickSwitchRegister()
    {
        Reg.SetActive(true);
        Log.SetActive(false);
    }

    public void OnClickSwitchLog()
    {
        Reg.SetActive(false);
        Log.SetActive(true);
    }


    private string saveDataAsJson()
    {
        patients patients = new patients(usernameInput.text, passowrdInput.text, AgeInput.text, Gender.text,"");
        string json = JsonUtility.ToJson(patients);

        

        reference.Child("patients").Child(usernameInput.text+passowrdInput.text + AgeInput.text+Gender.text).SetRawJsonValueAsync(json);

        return "Save data to firebase Done.";
    }





    private void retrieveData()
    {


        reference.Child("patients").GetValueAsync().ContinueWith(task =>
        {
            //
            if (task.IsFaulted)
            {
                // Handle the error...
            }
            else if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;


                foreach (DataSnapshot user in snapshot.Children)
                {
                    IDictionary dictUser = (IDictionary)user.Value;

                    if (usernameInputLogin.text.ToString() == dictUser["Name"].ToString() && passowrdInputLogin.text.ToString() == dictUser["Password"].ToString())
                    {
                        logintxt.text = "success";
                        SceneManager.LoadScene("selectLevel");
                        // launchApp();
                    }
                    else
                    {
                        logintxt.text = "failure";
                    }
                    Debug.Log("" + dictUser["Name"] + " - " + dictUser["Password"]);




                }
            }
        });


    }



}



public class patients
{
    public string Age;
    public string Password;
   
    public string Name;
    public string Gender;
    public string CurrentLevel;
   

    public patients()
    {
    }

    public patients(string Name, string Password, string Age, string Gender,string currentLevel)
    {
        this.Name = Name;
        this.Password = Password;
        this.Age = Age;
        this.CurrentLevel = currentLevel;
        this.Gender = Gender;
        //  this.ProgressIdication = ProgressIdication;
        //  this.StartLevel = StartLevel;

    }



}