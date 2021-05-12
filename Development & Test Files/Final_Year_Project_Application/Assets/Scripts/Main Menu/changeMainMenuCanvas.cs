using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMainMenuCanvas : MonoBehaviour
{

    public GameObject currentActiveCanvas;
    public GameObject nextActiveCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onCanvasChangeButtonClicked()
    {
        currentActiveCanvas.SetActive(false);
        nextActiveCanvas.SetActive(true);
    }
}
