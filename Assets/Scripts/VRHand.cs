using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRHand : MonoBehaviour
{
    public InputActionProperty triggerAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator animator;


    private void Update()
    {
        float triggerValue = triggerAnimationAction.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        animator.SetFloat("Grip", triggerValue);

        //// Old Input System
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Debug.Log("Called");
        //}

        // New Input System
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            Debug.Log("Called");
        }
    }
}
