using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTeleporter : MonoBehaviour
{
    public GameObject spawnArea;
    private Camera camera;

    public GameObject firstVRObject;
    private GameObject secondVrObject;

    public GameObject teleportPosition;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        secondVrObject = (GameObject)Resources.Load("Prefabs/VR/VRBuildMode");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButtonClicked()
    {
        firstVRObject.SetActive(false);
        Instantiate(secondVrObject, teleportPosition.transform.position, Quaternion.identity);
        camera.clearFlags = CameraClearFlags.Skybox;
        teleportPosition.SetActive(false);
    }
}
