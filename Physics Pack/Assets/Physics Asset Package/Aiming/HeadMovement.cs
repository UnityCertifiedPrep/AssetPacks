using UnityEngine;
using System.Collections;

public class HeadMovement : MonoBehaviour {

    public float sensitivity = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var HorizRot = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        var VertRot = -Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        transform.Rotate(Vector3.right, VertRot);
		// Rotation applied to local up by default, so we must inverse transform to get global up.
        transform.Rotate(transform.InverseTransformDirection(Vector3.up), HorizRot);
    }
}
