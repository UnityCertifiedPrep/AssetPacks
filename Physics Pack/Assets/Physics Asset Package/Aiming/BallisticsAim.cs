using UnityEngine;
using System.Collections;

public class BallisticsAim : MonoBehaviour {

    public BallisticSolver solver;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            solver.target = hitInfo.point;
        }
    }
}
