using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreenButton : MonoBehaviour
{
    public RectTransform fullWindowTransform;
    public RectTransform remoteImageTransform;
    public GameObject smallScreenButton;

    public void FullScreenMode()
    {
        remoteImageTransform.position = fullWindowTransform.position;
        remoteImageTransform.sizeDelta = fullWindowTransform.sizeDelta;
        smallScreenButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
