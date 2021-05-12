using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineManager : MonoBehaviour
{

    private Outline outline;
    private bool selectedObject;

    public GameObject[] uiObjects;

    // Start is called before the first frame update
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedObject)
        {
            foreach (GameObject uiObject in uiObjects)
            {
                uiObject.SetActive(true);
            }

        }
        else
        {
            foreach (GameObject uiObject in uiObjects)
            {
                uiObject.SetActive(false);
            }
        }
    }

    public void onTriggerClicked()
    {
        if (!outline.enabled)
        {
            outline.enabled = true;
            selectedObject = true;
        }
        else
        {
            outline.enabled = false;
            selectedObject = false;
        }


    }
}
