using UnityEngine;
using System.Collections;

public class ProjectileSpawner : MonoBehaviour {

    public GameObject ProjectilePrototype;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            Instantiate(ProjectilePrototype, transform.position, transform.rotation);
        }
	}
}
