using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetector : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        CharacterController controller = other.gameObject.GetComponent<CharacterController>();
        if (controller != null)
        {
            RaycastHit hit;
            if (!Physics.Linecast(transform.position, controller.transform.position+Vector3.up, out hit)) {
                // Nothing in between
                Debug.Log($"Player seen by {transform.parent.parent.gameObject.name}!", gameObject);
                controller.enabled = false;
                controller.transform.SetProperties(GameManager.Instance.transform);
                controller.enabled = true;
            }
        }
    }
}
