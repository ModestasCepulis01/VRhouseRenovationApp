using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrInputManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UIScreen;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();

        if(OVRInput.GetUp(OVRInput.RawButton.Y))
        {
            if(!UIScreen.activeSelf)
            {
                UIScreen.SetActive(true);
            }
            else
            {
                UIScreen.SetActive(false);
            }    
        }
    }
}
