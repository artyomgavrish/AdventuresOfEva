using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused = true;
    public GameObject EvaObject;
    public GameObject MenuObject;

    //private void Update()
    //{
    //    if (Input.GetKey("escape"))
    //    {
    //        EvaObject.SetActive(true);
    //        MenuObject.SetActive(false);
    //        Time.timeScale = 1;
    //    }
    //}

    public void ResumePressed()
    {
        EvaObject.SetActive(true);
        MenuObject.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void MainPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
