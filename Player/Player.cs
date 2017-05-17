using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour {

    Animator playerAnimator;
    Rigidbody rb;
    public float upJumpSpeed = 5;
    public float forwardJumpSpeed = 1;

	// Use this for initialization
	void Awake () {
        playerAnimator = GetComponent<Animator>();
        playerAnimator.applyRootMotion = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");


        playerAnimator.SetFloat("forwardSpeed", v);
        playerAnimator.SetFloat("turnSpeed", h);

        if (Input.GetButtonDown("Duck"))
        {
            playerAnimator.SetTrigger("duck");
        }

        if (Input.GetButtonDown("Jump"))
        {
            playerAnimator.SetTrigger("jump");
            rb.velocity += Vector3.up * upJumpSpeed + transform.forward * forwardJumpSpeed;
        }

        bool grounded = Mathf.Abs(Vector3.Dot(rb.velocity, Vector3.up)) < 0.01;
        playerAnimator.applyRootMotion = grounded;
        playerAnimator.SetBool("grounded", grounded);
    }
}
