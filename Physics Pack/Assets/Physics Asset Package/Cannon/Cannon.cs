using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour
{

    public float thrust = 500;

    void OnTriggerEnter(Collider other)
    {
        var rb = other.GetComponent<Rigidbody>();
        // Propel the projectile forward.
        rb.AddForce(gameObject.transform.up * thrust);
    }

}
