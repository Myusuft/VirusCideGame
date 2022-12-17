using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
    public Text scoreText;
    public void Start()
    {
        scoreText.text = ""+LevelScript.score;
    }

    // Update is called once per frame
    public void GoToHome()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void GoToScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}
