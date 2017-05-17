using UnityEngine;
using System.Collections;

public class ProjectileExpiry : MonoBehaviour
{

    public float expiryTime = 10;

    void Start()
    {
        Destroy(gameObject, expiryTime);
    }
}
