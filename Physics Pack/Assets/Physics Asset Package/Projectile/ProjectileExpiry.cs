using UnityEngine;
using System.Collections;

public class ProjectileExpiry : MonoBehaviour {

    public float expiryTime = 10;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, expiryTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
