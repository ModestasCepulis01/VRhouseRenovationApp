using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeObjectMaterial : MonoBehaviour
{
    //private MeshRenderer

    public Material materialToChangeTo;
    public GameObject objectToChangeTheMaterial;
    private Renderer objectRenderer;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = objectToChangeTheMaterial.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onMaterialChangeButtonClicked()
    {
        objectRenderer.material = materialToChangeTo;
    }
}
