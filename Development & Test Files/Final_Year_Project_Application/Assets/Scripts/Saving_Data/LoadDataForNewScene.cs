using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataForNewScene : MonoBehaviour
{

    public Save_Data_Handler dataHandler;
    public GameObject vrObject;

    public Vector3 vrObjectPosition;

    // Start is called before the first frame update
    void Start()
    {


        List<Vector3> allFloorPositions = dataHandler.returnFloorObjects();

        foreach (Vector3 floorPosition in allFloorPositions)
        {
            Instantiate(Resources.Load("Prefabs/BuildingFloors/FloorObjectToLoad Variant"), floorPosition, Quaternion.identity);
            print("floor object location: " + floorPosition);

            vrObjectPosition = floorPosition;
        }

        vrObject.transform.position = new Vector3(vrObjectPosition.x, vrObjectPosition.y + 5, vrObjectPosition.z);
        dataHandler.isSaveDataEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
