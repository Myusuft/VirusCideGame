using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GoToHomeScene", 3);
    }

    // Up
    void GoToHomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
