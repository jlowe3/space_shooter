using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity; 
    }
}
