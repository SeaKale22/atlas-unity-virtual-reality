using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerUIGaze : MonoBehaviour
{
    public AudioSource GazeInteractorAudio;
    public AudioClip HoverOn;
    public AudioClip Select;
    public AudioClip HoverOff;

    public void HoverStart()
    {
        GazeInteractorAudio.clip = HoverOn;
        GazeInteractorAudio.loop = true;
        GazeInteractorAudio.Play();
    }

    public void HoverStop()
    {
        GazeInteractorAudio.Stop();
        GazeInteractorAudio.loop = false;
        GazeInteractorAudio.clip = HoverOff;
        GazeInteractorAudio.Play();
    }

    public void HoverSelect()
    {
        GazeInteractorAudio.Stop();
        GazeInteractorAudio.loop = false;
        GazeInteractorAudio.clip = Select;
        GazeInteractorAudio.Play();
    }
}
