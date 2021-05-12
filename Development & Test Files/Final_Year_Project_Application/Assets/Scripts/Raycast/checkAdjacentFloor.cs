using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkAdjacentFloor : MonoBehaviour
{

    public GameObject spotToDrawFrom;
    public GameObject[] UIelementsToDisable;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        Debug.DrawRay(spotToDrawFrom.transform.position, transform.forward, Color.red, 1);

        if (Physics.Raycast(spotToDrawFrom.transform.position, transform.forward, out hit, 1))
        {

            if (hit.transform.tag == "Floor")
            {
                foreach (GameObject uiElement in UIelementsToDisable)
                {
                    uiElement.SetActive(false);
                }
                print("The floor is hit");
            }

        }
        else if(!Physics.Raycast(spotToDrawFrom.transform.position, transform.forward, out hit, 1))
        {
            foreach (GameObject uiElement in UIelementsToDisable)
            {
                uiElement.SetActive(true);
            }
            print("The floor is not hit");
        }
    }
}
