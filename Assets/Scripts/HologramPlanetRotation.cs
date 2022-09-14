using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HologramPlanetRotation : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));
    }
}
