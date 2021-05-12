using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Data_To_Spawn : MonoBehaviour
{
    // Start is called before the first frame update

    public static List<Vector3> allFloorPositions;

    void Start()
    {
        spawnAllFloors();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnAllFloors()
    {
        foreach(Vector3 floorPosition in allFloorPositions.ToArray())
        {
            GameObject floorObject = Instantiate(Resources.Load("Prefabs/BuildingFloors/Floors/FloorObject") as GameObject);
            floorObject.transform.position = floorPosition;
        }
    }
}
