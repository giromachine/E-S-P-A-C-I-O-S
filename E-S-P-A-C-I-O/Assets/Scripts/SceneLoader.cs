using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int[] SceneLoader.scenseChooser();

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LoadNextScene1()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scenseChooser[0]);
    }
    public void LoadNextScene2()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scenseChooser[1]);
    }
    public void LoadNextScene3()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scenseChooser[2]);
    }
    public void LoadNextScene4()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scenseChooser[3]);
    }
}
