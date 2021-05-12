using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class loadMenuManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Button loadMenuButton;
    void Start()
    {
        if (File.Exists(Application.dataPath + "/floors_data_save.txt"))
        {
            loadMenuButton.interactable = true;
        }
        else
        {
            loadMenuButton.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
