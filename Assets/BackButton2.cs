using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton2 : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
