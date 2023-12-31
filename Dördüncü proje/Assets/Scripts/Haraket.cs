using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haraket : MonoBehaviour
{
    public float speed = 5.0f;
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        Vector3 hizEklentisi = playerInput * Time.deltaTime * speed;
        transform.Translate(hizEklentisi);

    }
}
