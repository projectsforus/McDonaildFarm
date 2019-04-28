using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Text.RegularExpressions;

public class Register : MonoBehaviour {
    public GameObject username;
    public GameObject age;
    public GameObject gender;
    public GameObject password;
    public GameObject confPassword;
    private string Username;
    private string Age;
    private string Gender;
    private string Password;
    private string ConfPassword;
    private string form;

    private string[] Characters = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                                   "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                   "1","2","3","4","5","6","7","8","9","0","_","-"};

    public void RegisterButton() {
        bool UN = false;
        bool A = false;
        bool G = false;
        bool PW = false;
        bool CPW = false;

        if (Username != "") {
            if (!System.IO.File.Exists(@"E:/UnityTestFolder/" + Username + ".txt")) {
                UN = true;
            } else {
                Debug.LogWarning("Username Taken");
            }
        } else {
            Debug.LogWarning("Username field Empty");
        }
        if (Age != "") {
            if (!System.IO.File.Exists(@"E:/UnityTestFolder/" + Age + ".txt"))
            {
                A = true;

            } else
            {
                Debug.LogWarning("Age field Empty");
            }
        }

        if (Password != "") {
            if (Password.Length > 5) {
                PW = true;
            } else {
                Debug.LogWarning("Password Must Be atleast 6 Characters long");
            }
        } else {
            Debug.LogWarning("Password Field Empty");
        }
        if (ConfPassword != "") {
            if (ConfPassword == Password) {
                CPW = true;
            } else {
                Debug.LogWarning("Passwords Don't Match");
            }
        } else {
            Debug.LogWarning("Confirm Password Field Empty");
        }
        if (UN == true && A == true && G == true && PW == true && CPW == true) {
            bool Clear = true;
            int i = 1;
            foreach (char c in Password) {
                if (Clear) {
                    Password = "";
                    Clear = false;
                }
                i++;
                char Encrypted = (char)(c * i);
                Password += Encrypted.ToString();
            }
            form = (Username + Environment.NewLine + Age + Environment.NewLine + Gender + Environment.NewLine + Password);
            System.IO.File.WriteAllText(@"E:/UnityTestFolder/" + Username + ".txt", form);
            username.GetComponent<InputField>().text = "";
            age.GetComponent<InputField>().text = "";
            gender.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confPassword.GetComponent<InputField>().text = "";
            print("Registration Complete");

        }
    }
        // Update is called once per frame
        void Update() {
            if (Input.GetKeyDown(KeyCode.Tab)) {
                if (username.GetComponent<Arabic_UGUI_InputField>().isFocused) {
                    age.GetComponent<Arabic_UGUI_InputField>().Select();
                }
                if (age.GetComponent<Arabic_UGUI_InputField>().isFocused) {
                    gender.GetComponent<Arabic_UGUI_InputField>().Select();
                }
                if (gender.GetComponent<Arabic_UGUI_InputField>().isFocused) {
                    password.GetComponent<Arabic_UGUI_InputField>().Select();
                }
                if (password.GetComponent<Arabic_UGUI_InputField>().isFocused) {
                confPassword.GetComponent<Arabic_UGUI_InputField>().Select();
                }
            }
            if (Input.GetKeyDown(KeyCode.Return)) {
                if (Password != "" && Age != "" && Password != "" && ConfPassword != "") {
                    RegisterButton();
                }
            }
            Username = username.GetComponent<InputField>().text;
            Age = age.GetComponent<InputField>().text;
            Gender = age.GetComponent<InputField>().text;
            Password = password.GetComponent<InputField>().text;
            ConfPassword = confPassword.GetComponent<InputField>().text;
        }


    }
