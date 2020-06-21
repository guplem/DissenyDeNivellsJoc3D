using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private SimpleAnimationsManager fan, barrier;

    private void Awake()
    {
        Instance = this;
    }

    public bool hasKey {
        get => _hasKey;
        set => _hasKey = value;
    }
    public bool hasId {
        get => _hasId;
        set => _hasId = value;
    }
    public bool hasFanControl
    {
        get => _hasFanControl;
        set
        {
            if (value)
                fan.Play(0);
            _hasFanControl = value;
        }
    }

    public bool hasDiamond {
        get => _hasDiamond;
        set => _hasDiamond = value;
    }
    public bool hasBarrierControl {
        get => _hasBarrierControl;
        set
        {
            if (value)
                barrier.Play(0);
            _hasBarrierControl = value;
        }
    }
    public bool hasCameraControl {
        get => _hasCameraControl;
        set => _hasCameraControl = value;
    }
    
    [SerializeField] private bool _hasKey = false;
    [SerializeField] private bool _hasId = false;
    private bool _hasFanControl = false;
    [SerializeField] private bool _hasDiamond = false;
    private bool _hasBarrierControl = false;
    [SerializeField] private bool _hasCameraControl = false;
    
}
