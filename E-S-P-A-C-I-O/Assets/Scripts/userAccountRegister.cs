using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class userAccountRegister : MonoBehaviour
{

    public InputField emailInputField;
    public InputField passInputField;
    public InputField pass2InputField;

    public Text alert;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void clickOnButton()
    {
        if(emailInputField.text != "" && passInputField.text != "" && pass2InputField.text != "")
        {
            if(passInputField.text != pass2InputField.text)
            {
                Debug.Log("No coinciden sus contraseñas!");
                alert.text = "Sus credenciales no coinciden!";
            }
            else
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(4);
                AccountData.Mail = emailInputField.text;
                AccountData.Pass = passInputField.text;
            }
        }
    }



    public void CopyText(){
        //myTextBox.text = myInputField.text;
    }
    private void SubmitText(string arg0)
    {
        Debug.Log(arg0);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
