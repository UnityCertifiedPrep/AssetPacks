using UnityEngine;
using System.Collections;

public class MovingTarget : MonoBehaviour
{

    public float timePerCycle = 1;
    public float magnitude = 10;

    Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Move the target with a smooth cosine wave
        var x = magnitude * Mathf.Cos(Time.time / timePerCycle * 2 * Mathf.PI);
        transform.position = initialPosition + Vector3.left * x;
    }
}
