using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractable : Interactable
{
    public enum Locking
    {
        Key,
        Id,
        FanControl,
        Diamond,
        BarrierControl,
        CameraControl,
    }

    public Locking item;
    [SerializeField] private List<MeshRenderer> meshRenderersToColor;
    
    private MaterialPropertyBlock block;
    private static readonly int baseColor = Shader.PropertyToID("_BaseColor");

    public override void Interact()
    {
        if (block == null)
            block = new MaterialPropertyBlock();
        foreach (MeshRenderer mr in meshRenderersToColor)
        {
            block.SetColor(baseColor, new Color(0f, 1f, 0.3f, 1f));
            mr.SetPropertyBlock(block);
        }
        
        switch (item)
        {
            case Locking.Key:
                GameManager.Instance.hasKey = true;
                break;
            case Locking.Id:
                GameManager.Instance.hasId = true;
                break;
            case Locking.FanControl:
                GameManager.Instance.hasFanControl = true;
                break;
            case Locking.Diamond:
                GameManager.Instance.hasDiamond = true;
                break;
            case Locking.BarrierControl:
                GameManager.Instance.hasBarrierControl = true;
                break;
            case Locking.CameraControl:
                GameManager.Instance.hasCameraControl = true;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        base.Interact();
    }
}
