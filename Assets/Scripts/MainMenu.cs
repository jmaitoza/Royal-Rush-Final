using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("DesertLevel 1");
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("DesertLevel 1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("DesertLevel 2");
    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene("DesertLevel 3");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
