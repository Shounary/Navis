using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram : MonoBehaviour
{
    public HologramPlanetRotation hpr;
    public SkyboxRotation sr;
    public GameObject textTooltip;

    private void OnTriggerEnter(Collider other)
    {
        textTooltip.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && textTooltip.activeSelf)
        {
            hpr.enabled = !hpr.enabled;
            sr.enabled = !sr.enabled;
            textTooltip.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        textTooltip.SetActive(false);
    }
}
