using UnityEngine;
using System.Collections;

public class ProjectileSpawner : MonoBehaviour
{

    public GameObject ProjectilePrototype;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrototype, transform.position, transform.rotation);
        }
    }
}
