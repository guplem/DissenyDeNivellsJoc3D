using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public bool hasKey = false;
    public bool hasId = false;
    public bool hasFanControl = false;
    public bool hasDiamond = false;
    public bool hasBarrierControl = false;
    public bool hasCameraControl = false;
    
}
