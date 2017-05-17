using UnityEngine;
using System.Collections;

public class BallisticSolver : MonoBehaviour
{

    public Vector3 target;
    public float launchVelocity;

    void Update()
    {
        Vector3 launchDirection = SolveBalistics(target - transform.position);
        transform.rotation = Quaternion.LookRotation(launchDirection, Vector3.up);
    }

    Vector3 SolveBalistics(Vector3 target)
    {
        var g = Physics.gravity.magnitude;
        var v = launchVelocity;
        var horizontalVector = Vector3.ProjectOnPlane(target, Vector3.up);
        var verticalVector = Vector3.Project(target, Vector3.up);
        Debug.DrawLine(transform.position, horizontalVector);
        var x = horizontalVector.magnitude;
        var y = verticalVector.magnitude;

        // Find angle required to launch using trajectory equation https://en.wikipedia.org/wiki/Trajectory_of_a_projectile#Angle_.7F.27.22.60UNIQ--postMath-00000010-QINU.60.22.27.7F_required_to_hit_coordinate_.28x.2Cy.29
        var descriminant = Mathf.Pow(v, 4) - g * (g * x * x + 2 * y * v * v);
        // If negative, won't sqrt and so there's no solution.
        if (descriminant >= 0)
        {
            var theta1 = Mathf.Atan((v * v + Mathf.Sqrt(descriminant)) / (g * x));
            var theta2 = Mathf.Atan((v * v - Mathf.Sqrt(descriminant)) / (g * x));
            // There will be two solutions, the high arch and the low arch. We choose the low arch.
            var theta = Mathf.Min(theta1, theta2);
            return Vector3.RotateTowards(horizontalVector, Vector3.up, theta, Mathf.Infinity);
        }

        return Vector3.zero;
    }
}
