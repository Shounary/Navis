using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginRotation : MonoBehaviour
{
    public Transform origin;

    public Vector3 rotationPerSecond;

    void Update()
    {
        origin.Rotate(rotationPerSecond * Time.deltaTime);
    }
}
