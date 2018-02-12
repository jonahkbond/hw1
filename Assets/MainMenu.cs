﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame1()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void PlayGame2 ()
    {
        SceneManager.LoadScene("scene2");
    }

    public void QuitGame ()
    {
        Debug.Log("Quiting Game");
        Application.Quit();
    }
}
