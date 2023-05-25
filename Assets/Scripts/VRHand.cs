using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRHand : MonoBehaviour
{
    public InputActionProperty activateAnimationAction;
    public InputActionProperty selectAnimationAction;
    public Animator animator;


    XRIDefaultInputActions inputActions;

    private void Start()
    {
        // Action Map Trial 
        inputActions = new XRIDefaultInputActions();

        inputActions.XRILeftHandInteraction.Enable();
        inputActions.XRILeftHandInteraction.Activate.performed += HandActivate;
        inputActions.XRILeftHandInteraction.Select.performed += HandSelect;

        inputActions.XRIRightHandInteraction.Enable();
        inputActions.XRIRightHandInteraction.Activate.performed += HandActivate;
        inputActions.XRIRightHandInteraction.Select.performed += HandSelect;

        inputActions.TestngMap.Enable();
        inputActions.TestngMap.Testing.performed += Testing;
    }

    private void Update()
    {
        float triggerValue = activateAnimationAction.action.ReadValue<float>();
        animator.SetFloat("Activate", triggerValue);

        float gripValue = selectAnimationAction.action.ReadValue<float>();
        animator.SetFloat("Select", gripValue);

        //// Old Input System
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Debug.Log("Called");
        //}

        //// New Input System
        //if (Keyboard.current.aKey.wasPressedThisFrame)
        //{
        //    Debug.Log("Called");
        //}

    }

    public void HandActivate(InputAction.CallbackContext callbackContext) 
    {
        // Debug.Log("Hand Activate");
    }

    public void HandSelect(InputAction.CallbackContext callbackContext)
    {
        // Debug.Log("Hand Select");
    }

    public void Testing(InputAction.CallbackContext callbackContext)
    {
        // Debug.Log("Testing");
    }
}
