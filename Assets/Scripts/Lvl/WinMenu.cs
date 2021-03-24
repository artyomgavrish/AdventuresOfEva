using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void NextPressed()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void MainPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
