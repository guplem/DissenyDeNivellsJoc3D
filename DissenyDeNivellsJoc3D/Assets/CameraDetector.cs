using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetector : MonoBehaviour
{
    [SerializeField] private Transform cameraPosition;

    private Vector3 heightCheck = Vector3.up * 0.1f;
    private void OnTriggerStay(Collider other)
    {
        CharacterController controller = other.gameObject.GetComponent<CharacterController>();
        if (controller != null)
        {
            RaycastHit hit;
            if (!Physics.Linecast(cameraPosition.position, controller.transform.position+heightCheck, out hit)) {
                // Nothing in between
                Debug.Log($"Player seen by {transform.parent.parent.gameObject.name}!", gameObject);
                Debug.DrawLine(cameraPosition.position, controller.transform.position+heightCheck, Color.yellow, 10);
                Debug.Break();
                controller.enabled = false;
                controller.transform.SetProperties(GameManager.Instance.transform);
                controller.enabled = true;
            }
        }
    }
}
