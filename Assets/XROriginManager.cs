using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameManager
{
    public class XROriginManager : MonoBehaviour
    {
        #region Declaration

        [Header("Input Action Property")]
        [SerializeField] private InputActionProperty leftHandActivateAnimationAction;
        [SerializeField] private InputActionProperty leftHandSelectAnimationAction;
        [SerializeField] private InputActionProperty rightHandActivateAnimationAction;
        [SerializeField] private InputActionProperty rightHandSelectAnimationAction;

        [Header("Animator")]
        [SerializeField] private Animator leftHandAnimator;
        [SerializeField] private Animator rightHandAnimator;

        #endregion

        private void Update()
        {
            UpdateHandAnimation();
        }

        public void UpdateHandAnimation()
        {
            float leftHandActivateValue = leftHandActivateAnimationAction.action.ReadValue<float>();
            float leftHandSelectValue = leftHandSelectAnimationAction.action.ReadValue<float>();
            float rightHandActivateValue = rightHandActivateAnimationAction.action.ReadValue<float>();
            float rightHandSelectValue = rightHandSelectAnimationAction.action.ReadValue<float>();

            leftHandAnimator.SetFloat("Activate", leftHandActivateValue);
            leftHandAnimator.SetFloat("Select", leftHandSelectValue);
            rightHandAnimator.SetFloat("Activate", rightHandActivateValue);
            rightHandAnimator.SetFloat("Select", rightHandSelectValue);
        }
    }
}