using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
bool hasPackage = false;
[SerializeField] float DestroyDelay = 0.1f;

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Gaadii thok diii BC.......");
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        
        if (other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, DestroyDelay);
        }
        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
        }
    }

}
