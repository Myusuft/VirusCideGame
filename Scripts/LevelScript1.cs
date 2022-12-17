using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelScript1 : MonoBehaviour
{
    public void GoToScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}
