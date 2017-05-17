using UnityEngine;
using System.Collections;

public class ProjectileDebug : MonoBehaviour
{

    void Update()
    {
        print(GetComponent<Rigidbody>().velocity.magnitude);
    }
}
