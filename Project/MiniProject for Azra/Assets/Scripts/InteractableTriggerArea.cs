using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTriggerArea : MonoBehaviour
{
    [SerializeField] GameObject _canvasUI;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (other.CompareTag("Player"))
        {
            _canvasUI.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        _canvasUI.SetActive(false);
    }
}
