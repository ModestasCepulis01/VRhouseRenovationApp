using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : MonoBehaviour
{



    //UI Objects
    public GameObject zWallObjectUIPositionTop;
    public GameObject xWallObjectUIPositionRight;
    public GameObject xWallObjectUIPositionLeft;
    public GameObject zWallObjectUIPositionBottom;

    public Canvas floorCanvas;
    private Camera vrCameraObject;

    //value to increase by:
    public float valueToIncreaseOrDecreaseBy = 1f;
    public float valueToIncreaseTheWallHeightBy = 2.3f;

    //wall thickness
    public float wallThickness = 0.5f;

    //wall gmaeobject
    private GameObject xWallObject;
    private GameObject zWallObject;

    //the floor object
    public GameObject floorObject;

    //the object that the floor is attached to:
    public GameObject mainObject;

    //global variable for y wall position:
    private float yValueForfloor;

    // Start is called before the first frame update
    void Start()
    {
        vrCameraObject = FindObjectOfType<Camera>();
        floorCanvas.worldCamera = vrCameraObject;

        xWallObject = (GameObject)Resources.Load("Prefabs/Walls/xWall");
        zWallObject = (GameObject)Resources.Load("Prefabs/Walls/zWall");

        yValueForfloor = (valueToIncreaseTheWallHeightBy * floorObject.transform.localScale.y) + mainObject.transform.position.y;

        //  outline.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

  

    //to decrease any of this code I need to put variables inside of the methods
    //and make a different class that would call this specific class with other variables provided by the object of the class
    //=================================================TOP
    public void increaseZvalueTop()
    {
        //increase floor scale:
        gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + valueToIncreaseOrDecreaseBy);
    }

    public void decreaseZvalueTop()
    {
        //floor
        gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z - valueToIncreaseOrDecreaseBy);
    }

    //=========================================BOTTOM

    public void increaseZvalueBottom()
    {
        //increase floor scale:
        gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + valueToIncreaseOrDecreaseBy);
    }

    public void decreaseZvalueBottom()
    {
        //floor
        gameObject.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z - valueToIncreaseOrDecreaseBy);
    }

    //======================RIGHT==========================================

    public void increaseXvalueRight()
    {
        //floor
        gameObject.transform.localScale = new Vector3(transform.localScale.x + valueToIncreaseOrDecreaseBy, transform.localScale.y, transform.localScale.z);
    }

    public void decreaseXvalueRight()
    {
        //floor
        gameObject.transform.localScale = new Vector3(transform.localScale.x - valueToIncreaseOrDecreaseBy, transform.localScale.y, transform.localScale.z);
    }

    //======================LEFT==========================================

    public void increaseXvalueLeft()
    {
        //floor
        gameObject.transform.localScale = new Vector3(transform.localScale.x + valueToIncreaseOrDecreaseBy, transform.localScale.y, transform.localScale.z);
    }

    public void decreaseXvalueLeft()
    {
        //floor
        gameObject.transform.localScale = new Vector3(transform.localScale.x - valueToIncreaseOrDecreaseBy, transform.localScale.y, transform.localScale.z);
    }



    public void buildZValueWallTop()
    {
        print("top wall built");
        Vector3 zWallTopPosition = new Vector3(zWallObjectUIPositionTop.transform.position.x,
        yValueForfloor, zWallObjectUIPositionTop.transform.position.z);
        //Vector3 zWallUiPosition = new Vector3(zWallObjectUIPosition.transform.position.x, zWallObjectUIPosition.transform.position.y, zWallObjectUIPosition.transform.position.z);
        GameObject zWallTop = Instantiate(xWallObject, zWallTopPosition, Quaternion.identity);
       // zWallTop.transform.parent = floorObject.transform;
        zWallTop.GetComponent<MeshRenderer>().enabled = true;

        zWallTop.transform.localScale = new Vector3(floorObject.transform.localScale.x, valueToIncreaseTheWallHeightBy, wallThickness);

    }

    public void buildZValueWallBottom()
    {
        print("bottom wall built");

        

        Vector3 zWallBottomPosition = new Vector3(zWallObjectUIPositionBottom.transform.position.x, yValueForfloor,
            zWallObjectUIPositionBottom.transform.position.z);


        GameObject zWallBottom = Instantiate(xWallObject, zWallBottomPosition, Quaternion.identity);
       // zWallBottom.transform.parent = floorObject.transform;
        zWallBottom.GetComponent<MeshRenderer>().enabled = true;

        zWallBottom.transform.localScale = new Vector3(floorObject.transform.localScale.x, valueToIncreaseTheWallHeightBy, wallThickness);
    }

    public void buildXValueWallRight()
    {
        print("top wall right");

        Vector3 xWallRightPosition = new Vector3(xWallObjectUIPositionRight.transform.position.x,
        yValueForfloor, xWallObjectUIPositionRight.transform.position.z);
        GameObject xWall = Instantiate(zWallObject, xWallRightPosition, Quaternion.identity);
      //  xWall.transform.parent = floorObject.transform;
        xWall.GetComponent<MeshRenderer>().enabled = true;

        xWall.transform.localScale = new Vector3(wallThickness, valueToIncreaseTheWallHeightBy, floorObject.transform.localScale.z);
    }

    public void buildXValueWallLeft()
    {
        print("top wall left");
        Vector3 xWallLeftPosition = new Vector3(xWallObjectUIPositionLeft.transform.position.x,
        yValueForfloor, xWallObjectUIPositionLeft.transform.position.z);
        // Vector3 zWallUiPosition = new Vector3(zWallObjectUIPosition.transform.position.x, zWallObjectUIPosition.transform.position.y, zWallObjectUIPosition.transform.position.z);
        GameObject xWall = Instantiate(zWallObject, xWallLeftPosition, Quaternion.identity);
       // xWall.transform.parent = floorObject.transform;
        xWall.GetComponent<MeshRenderer>().enabled = true;

        xWall.transform.localScale = new Vector3(wallThickness, valueToIncreaseTheWallHeightBy, floorObject.transform.localScale.z);
    }

}
