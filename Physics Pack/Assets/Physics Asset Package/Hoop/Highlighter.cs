using UnityEngine;
using System.Collections;

public class Highlighter : MonoBehaviour {

    public Material highlightMaterial;
    Material original;
    public float highlightTime = 5;
    float highlightExpireTime = 0;

	// Use this for initialization
	void Start () {
        original = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time > highlightExpireTime)
        {
            GetComponent<Renderer>().material = original;
        }
	}

    public void Highlight()
    {
        GetComponent<Renderer>().material = highlightMaterial;
        highlightExpireTime = Time.time + highlightTime;
    }
}
