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
    private float GazeTimeSet;
    
    // Start is called before the first frame update
    void Start()
    {
        GazeTimeSlider.value = PlayerPrefs.GetFloat("GazeHoverTime");
        GazeTimeSlider.onValueChanged.AddListener(UpdateValue);
        GazeTimeText.text = $"Gaze Selection Time: {GazeTimeSlider.value} ";
        Apply();
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
    }
    
    public void MainMenu()
    {
        mainMenuCanvas.SetActive(true);
        optionsCanvas.SetActive(false);
    }
}
