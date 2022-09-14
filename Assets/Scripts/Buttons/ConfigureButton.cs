using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigureButton : MonoBehaviour
{
    public GameObject configureCanvas;

    public void ToggleConfigureCanvas()
    {
        configureCanvas.SetActive(!configureCanvas.activeSelf);
    }
}
