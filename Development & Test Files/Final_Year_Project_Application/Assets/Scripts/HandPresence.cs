using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    public InputDeviceCharacteristics controllerCharacteristics;
    private InputDevice targetDevice;

    public GameObject handModelPrefab;
    private GameObject spawnedHandModel;

    private Animator handAnimator;


    // Start is called before the first frame update
    void Start()
    {
        tryInitialize();
    }



    // Update is called once per frame
    void Update()
    {

        updateAnimation();
        checkIfDeviceExists();

        targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue);
        if(primary2DAxisValue != Vector2.zero)
        {
            //Debug.Log("Primary touchpad " + primary2DAxisValue);
        }

    }

    void updateAnimation()
    {               
        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            handAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Trigger", 0);
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
            handAnimator.SetFloat("Grip", 0);
        }
    }

    void tryInitialize()
    {
        List<InputDevice> devices = new List<InputDevice>();
        // InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;

        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        spawnedHandModel = Instantiate(handModelPrefab, transform);
        handAnimator = spawnedHandModel.GetComponent<Animator>();

    }

    void checkIfDeviceExists()
    {
        if (!targetDevice.isValid)
        {
            tryInitialize();
        }
    }
}
