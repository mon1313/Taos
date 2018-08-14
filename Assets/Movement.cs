using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float _speedSlowDown;
    private Camera _mainCamera;

    void Start()
    {
        _speedSlowDown = 0.1f;
        _mainCamera = Camera.main;
    }

    void Update()
    {
        _mainCamera.transform.position += new Vector3(0, 1, 0);
        /*if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft))
        {
            Vector3 touchPos = Input.GetAxis(OVRInput.Button.PrimaryThumbstickLeft);
            Vector3 movementVector = new Vector3(touchPos.x - 0.5f, 0, touchPos.y - 0.5f); //adjust for center to be at 0.5, 0.5
            transform.Translate(movementVector.x * _speedSlowDown, 0, -movementVector.z * _speedSlowDown); // negative to adjust for the vector speed
        }  */
    }
}