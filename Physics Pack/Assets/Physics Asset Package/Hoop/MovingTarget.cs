using UnityEngine;
using System.Collections;

public class MovingTarget : MonoBehaviour {

    public float timePerCycle = 1;
    public float magnitude = 10;

    Vector3 initialPosition;

	// Use this for initialization
	void Start () {
        initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        var x = magnitude * Mathf.Cos(Time.time / timePerCycle * 2 * Mathf.PI);
        transform.position = initialPosition + Vector3.left * x;
	}
}
