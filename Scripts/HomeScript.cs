using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void GoToMenuLevel()
    {
        SceneManager.LoadScene("MenuLevelScene");
    }

    public void GoToScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}
