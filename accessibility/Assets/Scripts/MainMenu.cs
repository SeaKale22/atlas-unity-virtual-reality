using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject optionsCanvas;

    // method for loading scene
    public void LoadScene(int num)
    {
        SceneManager.LoadScene(num);
    }

    // activates options canvas
    public void Options()
    {
        optionsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    // quits game
    public void QuitGame()
    {
        Application.Quit();
    }
}
