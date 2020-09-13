using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public void NextScene (string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void CloseApplication () 
    {
        Application.Quit();
    }

    public void undoTime ()
    {
        Time.timeScale = 1f;
    }

}