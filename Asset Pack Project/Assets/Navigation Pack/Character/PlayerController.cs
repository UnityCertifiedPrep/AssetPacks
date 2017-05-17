using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Character))]
public class PlayerController : MonoBehaviour {

    Character character;

	// Use this for initialization
	void Start () {
        character = GetComponent<Character>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        character.SetForwardSpeed(v);
        character.SetTurnSpeed(h);

        if (Input.GetButtonDown("Duck"))
        {
            character.Duck();
        }

        if (Input.GetButtonDown("Jump"))
        {
            character.Jump();
        }
    }
}
