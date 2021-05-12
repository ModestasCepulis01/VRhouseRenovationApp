using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    public float size = 1f;
    public GameObject plusButton;
    private GameObject button;
    public GameObject floorObject;

    public GameObject teleportButton;
    public List<GameObject> allButtons;


    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xCount = Mathf.RoundToInt(position.x / size);
        int yCount = Mathf.RoundToInt(position.y / size);
        int zCount = Mathf.RoundToInt(position.z / size);

        Vector3 result = new Vector3((float)xCount * size,
                                     (float)yCount * size,
                                     (float)zCount * size);

        result += transform.position;
        return result;

        //This helps to manage the scaling of the grid, if we want to make the grid bigger, the grid points would move
        //And the spawning of the floors would still work.
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (float x = 0; x < 100; x += size)
        {
            for (float z = 0; z < 100; z += size)
            {
                var point = GetNearestPointOnGrid(new Vector3(x, 0f, z));
                Gizmos.DrawSphere(point, 1f);
            }
        }
    }

    private void Awake()
    {
    }

    void Start()
    {
        allButtons = new List<GameObject>();

        for (float x = 0; x < 100; x += size)
        {
            for (float z = 0; z < 100; z += size)
            {
                Vector3 vector3Point = GetNearestPointOnGrid(new Vector3(x, 0f, z));
                button = Instantiate(plusButton, vector3Point, Quaternion.identity);

                foreach(GameObject button in GameObject.FindGameObjectsWithTag("Button"))
                {
                    allButtons.Add(button);
                }
            }
        }

        allButtons.Add(teleportButton);
    }

    private void LateUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void disableAllButtonsOnClick()
    {
        foreach(GameObject button in allButtons)
        {
            if(button.activeSelf)
            {
                button.SetActive(false);
            }
            else
            {
                print("The Object is disabled, cant disable the object");
            }
        }
    }

}
