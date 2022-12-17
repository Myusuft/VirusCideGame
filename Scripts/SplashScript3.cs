using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScript3 : MonoBehaviour
{
    // float currentTime;
    // public float startingTime = 10f;

    // [SerializeField] Text countdownText;
    // Start is called before the first frame update

    public float timeValue = 60;
    public Text timerText;
    void Start()
    {
        Invoke("GoToGameOverScene", timeValue);
        //currentTime = startingTime;
    }

    // void Update()
    // {
    //     currentTime -= 1 * Time.deltaTime;
    //     countdownText.text = currentTime.ToString("0");

    //     if (currentTime <= 0)
    //     {
    //         currentTime = 0;
    //         // Your Code Here
    //     }
    // }

    // Up
    void GoToGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    

  //Update is called once per frame
  void Update()
  {
    if (timeValue > 0)
    {
      timeValue -= Time.deltaTime;
    }
    else
    {
     timeValue = 0;
    }

    DisplayTime(timeValue);
   }

   void DisplayTime(float timeToDisplay)
   {
    if (timeToDisplay < 0)
    {
      timeToDisplay = 0;
    }

    else
    {
    Debug.Log("Time has run out!");
    }

    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);

    timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

  

   }
}
