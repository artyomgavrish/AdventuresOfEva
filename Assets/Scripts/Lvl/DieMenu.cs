using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DieMenu : MonoBehaviour
{
    public void RestartPressed()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void MainPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
