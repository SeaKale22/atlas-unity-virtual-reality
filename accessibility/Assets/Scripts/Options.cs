using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Options : MonoBehaviour
{
    public XRGazeInteractor GazeInteractor;
    
    public GameObject mainMenuCanvas;
    public GameObject optionsCanvas;
    public Slider GazeTimeSlider;
    public TMP_Text GazeTimeText;
    public GameObject vignetting;
    public Toggle VignettToggle;
    
    private float GazeTimeSet;
    private int VignettOn;
    
    // Start is called before the first frame update
    void Start()
    {
        GazeTimeSlider.value = PlayerPrefs.GetFloat("GazeHoverTime");
        GazeTimeSlider.onValueChanged.AddListener(UpdateValue);
        GazeTimeText.text = $"Gaze Selection Time: {GazeTimeSlider.value} ";
        Apply();

        VignettOn = PlayerPrefs.GetInt("Vignetting", 0);
        if (VignettOn == 1)
        {
            vignetting.SetActive(true);
            VignettToggle.isOn = true;
        }
        else
        {
            vignetting.SetActive(false);
            VignettToggle.isOn = false;
        }
    }

    // Update is called once per frame
    void UpdateValue(float newValue)
    {
        GazeTimeSet = newValue;
        GazeTimeText.text = $"Gaze Selection Time: {GazeTimeSet} ";
        PlayerPrefs.SetFloat("GazeHoverTime", GazeTimeSet);
    }

    public void Apply()
    {
        GazeInteractor.hoverTimeToSelect = PlayerPrefs.GetFloat("GazeHoverTime");
        
        if (VignettOn == 1)
        {
            vignetting.SetActive(true);
        }
        else
        {
            vignetting.SetActive(false);
        }
    }
    
    public void MainMenu()
    {
        mainMenuCanvas.SetActive(true);
        optionsCanvas.SetActive(false);
    }

    public void VignettOnOff()
    {
        if (VignettOn == 1)
        {
            PlayerPrefs.SetInt("Vignetting", 0);
            VignettOn = 0;
            vignetting.SetActive(false);
        }
        else
        {
            PlayerPrefs.SetInt("Vignetting", 1);
            VignettOn = 1;
            vignetting.SetActive(true);
        }
    }
}
