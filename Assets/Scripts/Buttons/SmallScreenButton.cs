using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallScreenButton : MonoBehaviour
{
    public RectTransform smallWindowTransform;
    public RectTransform remoteImageTransform;
    public GameObject fullScreenButton;

    public void SmallScreenMode()
    {
        remoteImageTransform.position = smallWindowTransform.position;
        remoteImageTransform.sizeDelta = smallWindowTransform.sizeDelta;
        fullScreenButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
