using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotation : MonoBehaviour
{
    public float rotationSpeed = 0.5f;
    private float rotation = 0f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", rotation += rotationSpeed * Time.deltaTime);
    }
}
