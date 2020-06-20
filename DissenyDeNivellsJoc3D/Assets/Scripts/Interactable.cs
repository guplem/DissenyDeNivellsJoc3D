using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool interacted = false;
    
    public virtual void Interact()
    {
        interacted = true;
        Debug.Log($"Interacting with {gameObject.name}");
    }
}
