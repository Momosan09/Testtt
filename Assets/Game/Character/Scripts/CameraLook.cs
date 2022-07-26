using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    public float sensivilidadMouse = 80f;

    public Transform playerBody;

    float xRotation = 0;

    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensivilidadMouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensivilidadMouse * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation,-90f,90f);

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);

        playerBody.Rotate(Vector3.up*mouseX);
    }
    
}
