using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelector : MonoBehaviour
{
    public Color yellow;
    public Color green;
    public Color red;
    public Color blue;

    public Renderer emission;
    public Light[] lights;

    public void YellowClick()
    {
        Material mat = emission.sharedMaterials[1];
        mat.SetColor("_EmissionColor", yellow);

        foreach (Light light in lights)
        {
            light.color = yellow;
        }
    }

    public void GreenClick()
    {
        Material mat = emission.sharedMaterials[1];
        mat.SetColor("_EmissionColor", green);

        foreach (Light light in lights)
        {
            light.color = green;
        }
    }

    public void RedClick()
    {
        Material mat = emission.sharedMaterials[1];
        mat.SetColor("_EmissionColor", red);

        foreach (Light light in lights)
        {
            light.color = red;
        }
    }

    public void BlueClick()
    {
        Material mat = emission.sharedMaterials[1];
        mat.SetColor("_EmissionColor", blue);

        foreach (Light light in lights)
        {
            light.color = blue;
        }
    }
}
