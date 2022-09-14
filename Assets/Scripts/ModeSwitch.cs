using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwitch : MonoBehaviour
{
    public Animator[] modeSwitchAnimators;

    public CharacterMovement playerMovement;

    // TODO: Add text tooltip

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            ToggleAnimators();
            TogglePlayerMovement();
            ToggleCursorLock();
        }
    }

    private void ToggleAnimators()
    {
        foreach (Animator animator in modeSwitchAnimators)
        {
            animator.SetBool("isMenuMode", !animator.GetBool("isMenuMode"));
        }
    }

    private void TogglePlayerMovement()
    {
        playerMovement.enabled = !playerMovement.enabled;
    }

    private void ToggleCursorLock()
    {   
        if (Cursor.lockState == CursorLockMode.Locked)
            Cursor.lockState = CursorLockMode.Confined;
        else
            Cursor.lockState = CursorLockMode.Locked;
    }
}
