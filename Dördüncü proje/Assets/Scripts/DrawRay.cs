using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DRA : MonoBehaviour
{
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red);
        
    }
}
