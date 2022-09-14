using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    public GameObject textTooltip;
    public AlarmBlinking alarm;

    private void OnTriggerEnter(Collider other)
    {
        textTooltip.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && textTooltip.activeSelf)
        {
            alarm.enabled = !alarm.enabled;
            textTooltip.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        textTooltip.SetActive(false);
    }
}
