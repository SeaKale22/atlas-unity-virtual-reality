using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoButtons : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void Pause()
    {
        Debug.Log("Vid Paused");
        videoPlayer.Pause();
    }

    public void Play()
    {
        Debug.Log("Vid Played");
        videoPlayer.Play();
    }
}
