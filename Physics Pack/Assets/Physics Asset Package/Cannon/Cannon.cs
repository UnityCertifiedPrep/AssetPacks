using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

    public float thrust = 500;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        var rb = other.GetComponent<Rigidbody>();
        rb.AddForce(gameObject.transform.up * thrust);
    }

}
