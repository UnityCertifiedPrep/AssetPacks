using UnityEngine;
using System.Collections;

public class ProjectileDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        print(GetComponent<Rigidbody>().velocity.magnitude);
	}
}
