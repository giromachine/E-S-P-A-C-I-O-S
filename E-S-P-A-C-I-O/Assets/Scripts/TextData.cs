using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextData : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int contador = 0;

    public string Mail;
    public GameObject inputFieldMail;
    public GameObject inputFieldPassW;
    public GameObject textDisplay;
    public string PassW;

    private void Awake()
    {
        int textDataCount = FindObjectsOfType<TextData>().Length;
        if (textDataCount > 1)
        {
            DestroyTextData();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddOne()
    {
        contador += 1;
        scoreText.text = contador.ToString();
    }
    public void RestOne()
    {
        if (contador > 0)
        {
            contador -= 1;
            scoreText.text = contador.ToString();
        }
    }
    private void DestroyTextData()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
    public void StoreMailandPass()
    {
        Mail = inputFieldMail.GetComponent<TextMeshProUGUI>().text;
        PassW = inputFieldPassW.GetComponent<TextMeshProUGUI>().text;
    }

}
