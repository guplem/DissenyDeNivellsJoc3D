using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : SimpleAnimationInteractable
{
    public enum Locking
    {
        Key,
        Id,
        Diamond,
    }

    public Locking itemNeeded;
    
    public override void Interact()
    {
        switch (itemNeeded)
        {
            case Locking.Key:
                if (!GameManager.Instance.hasKey) return;
                break;
            case Locking.Id:
                if (!GameManager.Instance.hasId) return;
                break;
            case Locking.Diamond:
                if (!GameManager.Instance.hasDiamond) return;
                break;
        }

        base.Interact();
    }
}
