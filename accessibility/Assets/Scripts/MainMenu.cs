using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject optionsCanvas;
    public XRGazeInteractor GazeInteractor;
    public GameObject vignetting;

    private float GazeSelectionTime;
    private int VignettOn;

    public void Start()
    {
        GazeSelectionTime = PlayerPrefs.GetFloat("GazeHoverTime", 1.5f);
        GazeInteractor.hoverTimeToSelect = GazeSelectionTime;
        VignettOn = PlayerPrefs.GetInt("Vignetting", 0);
        if (VignettOn == 1)
        {
            vignetting.SetActive(true);
        }
        else
        {
            vignetting.SetActive(false);
        }
    }

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
