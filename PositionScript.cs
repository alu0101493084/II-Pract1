using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScript : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Posición de " + gameObject.name + ": " + transform.position);
    }
}
