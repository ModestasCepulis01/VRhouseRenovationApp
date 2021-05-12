using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Saving_Floor_Data_Manager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] allFloors;
    public List<GameObject> allActiveFloors;

    public static Saving_Floor_Data_Manager instance;

    void Start()
    {
        instance = GetComponent<Saving_Floor_Data_Manager>();

    }

    // Update is called once per frame
    void Update()
    {

        FloorManager();

    }

    private void FloorManager()
    {
        allFloors = GameObject.FindGameObjectsWithTag("Floor");

        foreach (GameObject floor in allFloors.ToArray())
        {
            if (floor.GetComponent<MeshRenderer>().enabled)
            {
                if (!allActiveFloors.Contains(floor))
                {
                    allActiveFloors.Add(floor);
                    //Debug.Log(floor.transform.position);
                }

            }
            else
            {
                if(allActiveFloors != null)
                {
                    if (allActiveFloors.Contains(floor))
                    {
                        allActiveFloors.Remove(floor);
                    }
                }

            }
        }
    }

    public List<GameObject> returnAllActiveFloors()
    {
        return allActiveFloors;
    }
}
