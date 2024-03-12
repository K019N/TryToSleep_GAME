using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : Thing
{
    [SerializeField] private GameObject cameraInHands;
    [SerializeField] private GameObject cameraPanel;
    private bool isCamering = false;

    private void Update()
    {
        if (isTaken){
            cameraInHands.SetActive(true);
        }
        if (isTaken && Input.GetKey(KeyCode.F)){
            cameraPanel.SetActive(!isCamering);
            isCamering = !isCamering;
        }
    }
}
