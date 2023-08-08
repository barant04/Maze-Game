using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public void Level1Button()
    {
        SceneManager.LoadScene(3);
    }
    public void Level2Button()
    {
        SceneManager.LoadScene(4);
    }
    public void Level3Button()
    {
        SceneManager.LoadScene(5);
    }
}