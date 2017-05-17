using UnityEngine;
using System.Collections;

public class BallisticSolver : MonoBehaviour {

    public Vector3 target;
    public float launchVelocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 launchDirection = SolveBalistics(target - transform.position);
        transform.rotation = Quaternion.LookRotation(launchDirection, Vector3.up);
    }

    Vector3 SolveBalistics(Vector3 target)
    {
        var g = Physics.gravity.magnitude;
        var v = launchVelocity;
        var horizontalVector = Vector3.ProjectOnPlane(target, Vector3.up);
        Debug.DrawLine(transform.position, horizontalVector);
        var x = horizontalVector.magnitude;
        var y = Vector3.Project(target, Vector3.up).magnitude;

        var descriminant = Mathf.Pow(v, 4) - g * (g * x * x + 2 * y * v * v);
        if (descriminant >= 0)
        {
            var theta1 = Mathf.Atan((v * v + Mathf.Sqrt(descriminant)) / (g * x));
            var theta2 = Mathf.Atan((v * v - Mathf.Sqrt(descriminant)) / (g * x));
            var theta = Mathf.Min(theta1, theta2);
            return Vector3.RotateTowards(horizontalVector, Vector3.up, theta, Mathf.Infinity);
        }

        return Vector3.zero;
    }
}
