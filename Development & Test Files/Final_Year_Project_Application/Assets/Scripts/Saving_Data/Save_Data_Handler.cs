using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Save_Data_Handler : MonoBehaviour
{

    public List<GameObject> allActiveFloors;
    public bool isSaveDataEnabled;
    private List<Vector3> allFloorPositions = null;
    public string json = "";

    public static Save_Data_Handler instance;

    public List<floor_Objects> floorObjects;

    private void Awake()
    {
        instance = GetComponent<Save_Data_Handler>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isSaveDataEnabled)
        {
            //print("stuff is working");
            allActiveFloors = Saving_Floor_Data_Manager.instance.returnAllActiveFloors();
        }



    }

    [Serializable]
    public class floor_Objects
    {
        public string name;
        public Vector3 location;
    }

    public void SaveFloorsData()
    {
        if (File.Exists(Application.dataPath + "/floors_data_save.txt"))
        {
            File.Delete(Application.dataPath + "/floors_data_save.txt");
        }

        isSaveDataEnabled = false;
        Vector3[] positionList = returnAllPostionsOfFloors();

        string floorName = "Floor ";
        List<floor_Objects> floorObjects = new List<floor_Objects>();

        for (int i = 0; i<positionList.Length; i++)
        {

            if(positionList[i] != null)
            {
                floor_Objects floor_object = new floor_Objects();
                floor_object.name = floorName;
                floor_object.location = positionList[i];

                floorObjects.Add(floor_object);
            }
        }

        json = JsonConvert.SerializeObject(floorObjects, Formatting.Indented);
        File.WriteAllText(Application.dataPath + "/floors_data_save.txt", json);
    }

    public void LoadFloorsData()
    {
        SceneManager.LoadScene("LoadDataScene");
    }

    public List<Vector3> returnFloorObjects()
    {
        if (File.Exists(Application.dataPath + "/floors_data_save.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/floors_data_save.txt");

            floorObjects = JsonConvert.DeserializeObject<List<floor_Objects>>(saveString);
        }

        List<Vector3> allFloorPositions = new List<Vector3>();

        foreach(floor_Objects floorObject in floorObjects)
        {
            allFloorPositions.Add(floorObject.location);
        }

        return allFloorPositions;
    }

    public Vector3[] returnAllPostionsOfFloors()
    {

        isSaveDataEnabled = false;

        Vector3[] vectorLists = new Vector3[allActiveFloors.Count];

        int i = 0;

        if (!isSaveDataEnabled)
        {
            foreach (GameObject floorObject in allActiveFloors.ToArray())
            {
                vectorLists[i] = floorObject.transform.position;
                i++;

            }
        }
        else
        {
            return null;
        }


        return vectorLists;
    }

}
