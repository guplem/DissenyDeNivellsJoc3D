using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    [SerializeField] private SimpleAnimationsManager simpleAnimationsManager;
    [SerializeField] private new Light light;

    private void Start()
    {
        simpleAnimationsManager.Play(0);
    }

    public void Loop()
    {
        if (GameManager.Instance.hasCameraControl)
        {
            light.color = new Color(0f, 0.75f, 0.1f);
            return;
        }

        SimpleAnimation animation = simpleAnimationsManager.GetAnimation(0);
        animation.mirror = !animation.mirror;
        simpleAnimationsManager.Play(animation);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0.6f, 0.4f, 0.2f, 0.4f);
        Gizmos.matrix = this.transform.localToWorldMatrix;
        Gizmos.DrawCube(Vector3.zero, new Vector3(10, 0, 10));
    }

}
