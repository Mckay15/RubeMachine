using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play_button()
    {
        SceneManager.LoadScene("First", LoadSceneMode.Single);
    }
    public void Quit_button()
    {
        Application.Quit();
    }
}
