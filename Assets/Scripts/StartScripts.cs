using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScripts : MonoBehaviour
{
    public void StartGameButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
      // EditorApplication.Exit(0);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Start Game");
    }
}
