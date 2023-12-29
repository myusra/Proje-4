using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float MouseSensivity = 500f;
    public GameObject oyuncu;
  
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * MouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * MouseSensivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -180f, +180f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        oyuncu.transform.Rotate(Vector3.up * mouseX);

        
    }
}
