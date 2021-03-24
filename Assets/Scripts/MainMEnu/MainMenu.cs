﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1;
    }

    public void ExitPressed()
    {
        Application.Quit();
    }


}
