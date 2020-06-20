using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SimpleAnimationsManager))]
public class SimpleAnimationInteractable : Interactable
{
    private SimpleAnimationsManager simpleAnimationsManager;
    private void Awake()
    {
        simpleAnimationsManager = GetComponent<SimpleAnimationsManager>();
    }

    public override void Interact()
    {
        if (interacted) return;
        simpleAnimationsManager.Play(0);
        
        base.Interact();
    }
}
