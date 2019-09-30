using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSinking : MonoBehaviour
{
   private Rigidbody rb;
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

        void Start()
    {
        rb.inertiaTensor = rb.inertiaTensor + new Vector3(0, 0, rb.inertiaTensor.z * 100);
        rb.inertiaTensor = rb.inertiaTensor + new Vector3(0, rb.inertiaTensor.y * 100, 0);
        rb.inertiaTensor = rb.inertiaTensor + new Vector3(rb.inertiaTensor.x * 100, 0, 0);
    }
}
