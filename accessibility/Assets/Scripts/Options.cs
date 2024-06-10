using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject optionsCanvas;
    public Slider GazeTime;
    public TMP_Text GazeTimeText;
    private double GazeTimeSet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GazeTimeSet = GazeTime.value;
        GazeTimeSet = Math.Round(GazeTimeSet, 2);
        GazeTimeText.text = $"Gaze Selection Time: {GazeTimeSet} ";
    }
    
    public void MainMenu()
    {
        mainMenuCanvas.SetActive(true);
        optionsCanvas.SetActive(false);
    }
}
