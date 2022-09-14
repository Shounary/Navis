using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject textTooltip;


    private void OnTriggerEnter(Collider other)
    {
        textTooltip.SetActive(true);
        if (doorAnim.GetCurrentAnimatorStateInfo(0).IsName("glass_door_close") || doorAnim.GetCurrentAnimatorStateInfo(0).IsName("glass_door_closed"))
            textTooltip.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.E) && textTooltip.activeSelf)
        {
            doorAnim.SetBool("character_nearby", true);
            textTooltip.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnim.SetBool("character_nearby", false);
        textTooltip.SetActive(false);
    }
}
