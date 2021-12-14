using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("COLLISION DETECTED.");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("YOU HAVE ENTERED THE VOID.");

        if (other.tag == "Package" && !hasPackage) {
            Debug.Log("Package has been picked up.");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        } else if (other.tag == "Customer" && hasPackage) {
            Debug.Log("Delivery location.");
            hasPackage = false;
        }
    }
}
