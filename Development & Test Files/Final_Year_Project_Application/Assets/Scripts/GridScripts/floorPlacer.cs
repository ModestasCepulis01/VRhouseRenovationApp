using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class floorPlacer : MonoBehaviour
{
    private MeshRenderer mesh;
    private BoxCollider collider;

    // Start is called before the first frame update

    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        collider = GetComponent<BoxCollider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        collider.enabled = false;
        mesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onPlusButtonClickedWithTrigger()
    {
        collider.enabled = true;
        mesh.enabled = true;
    }

    public void onControllerRayMoveAndHit()
    {
        
    }

}
