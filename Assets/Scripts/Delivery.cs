using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    private void Start() {
        Debug.log(hasPackage);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("COLLISION DETECTED.");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // Debug.Log("YOU HAVE ENTERED THE VOID.");

        if (other.tag == "Package") {
            Debug.Log("Package has been picked up.");
        } else if (other.tag == "Customer") {
            Debug.Log("Delivery location.");
        }
    }
}
