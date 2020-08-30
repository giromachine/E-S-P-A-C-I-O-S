using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountData : MonoBehaviour
{

    public static string Mail;
    public static string Pass;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
