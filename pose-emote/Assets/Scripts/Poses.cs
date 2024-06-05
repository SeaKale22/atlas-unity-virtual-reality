using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poses : MonoBehaviour
{
    public BoxCollider faceBox;
    public BoxCollider leftBox;
    public BoxCollider rightBox;

    public GameObject leftController;
    public GameObject rightController;

    public Image canvasImage;

    public Sprite xPose;
    public Sprite facePalmPose;
    public Sprite thumbsUpPose;
    public Sprite wavePose;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    
}
