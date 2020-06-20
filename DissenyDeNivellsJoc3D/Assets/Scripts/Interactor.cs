using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Interactable interactable = other.GetComponent<Interactable>();
        if (interactable == null)
            interactable = other.GetComponentInParent<Interactable>();
        
        if (interactable != null)
            interactable.Interact();
    }
}
