using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restaurantAccountRegister : MonoBehaviour
{
    string url = "http://localhost/phpHackathon/userInsert.php";

    public InputField Name;

    public InputField Address;

    public InputField Phone;

    public Text Alert;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void ClickOnButton(){
        Debug.Log("Click!");
        StartCoroutine(SendData());
    }

    public IEnumerator SendData(){
        Debug.Log("Entro!");

        if(Name.text != "" && Address.text != "" && Phone.text != ""){
            WWWForm form = new WWWForm();

            form.AddField("name", Name.text);
            form.AddField("email", AccountData.Mail);
            form.AddField("pass", AccountData.Pass);
            form.AddField("address", Address.text);
            form.AddField("phone", Phone.text);

            using (UnityWebRequest www = UnityWebRequest.Post(url, form))
            {
                yield return www.SendWebRequest();

                if(www.isNetworkError || www.isHttpError)
                {
                    Debug.Log(www.error);
                    Alert.text = "Error al enviar datos.";
                }
                else
                {
                    Debug.Log("Form upload complete!");
                    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                    SceneManager.LoadScene(5);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
