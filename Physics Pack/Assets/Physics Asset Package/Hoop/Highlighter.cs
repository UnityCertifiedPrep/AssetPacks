using UnityEngine;
using System.Collections;

public class Highlighter : MonoBehaviour {

    public Material highlightMaterial;
    Material original;
    public float highlightTime = 5;
    float highlightExpireTime = 0;

	void Start () {
        // Keep material for later.
        original = GetComponent<Renderer>().material;
	}
	
	void Update () {
	    if (Time.time > highlightExpireTime)
        {
            // Reset the original material.
            GetComponent<Renderer>().material = original;
        }
	}

    public void Highlight()
    {
        GetComponent<Renderer>().material = highlightMaterial;
        highlightExpireTime = Time.time + highlightTime;
    }
}
