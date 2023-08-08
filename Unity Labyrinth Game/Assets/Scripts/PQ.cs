using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PQ : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(3);
    }
    public void LevelButton()
    {
        SceneManager.LoadScene(1);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}