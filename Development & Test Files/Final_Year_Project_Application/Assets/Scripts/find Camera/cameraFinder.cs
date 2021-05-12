using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFinder : MonoBehaviour
{

    public Canvas floorCanvas;
    private Camera vrCameraObject;

    // Start is called before the first frame update
    void Start()
    {
        vrCameraObject = FindObjectOfType<Camera>();
        floorCanvas.worldCamera = vrCameraObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
