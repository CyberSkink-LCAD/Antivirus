using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

interface IInteractable{
    public void Interact();
}

public class eddieinteract : MonoBehaviour
{
    public Transform Interactorsource;
    public float Interactrange;

    void Start() {
        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            Ray r = new Ray(Interactorsource.position, Interactorsource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, 1)){
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) {
                    interactObj.Interact();
                }
            }

        }
        
    }
}
