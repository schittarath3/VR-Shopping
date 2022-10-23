using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryInteraction : MonoBehaviour
{

    public GameObject inventoryPopUp;
    public Animator inventoryAnimator;
    public TMP_Text inventoryText;


    void PopUp(string text) {
        inventoryPopUp.SetActive(true);
        inventoryText.text = text;
        inventoryAnimator.SetTrigger("pop");
    }

    public InputActionReference toggleReference = null;

    void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    private void OnDestroy() {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context) {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }
}
