using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class Character : MonoBehaviour {

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
    void FixedUpdate ()
    {
        playerAnimator.applyRootMotion = Grounded();
        playerAnimator.SetBool("grounded", Grounded());
    }

    public bool Grounded()
    {
        return Mathf.Abs(Vector3.Dot(rb.velocity, Vector3.up)) < 0.01;
    }

    public void Jump()
    {
        if (Grounded())
        {
            playerAnimator.SetTrigger("jump");
            rb.velocity += Vector3.up * upJumpSpeed + transform.forward * forwardJumpSpeed;
        }
    }

    public void Duck()
    {
        playerAnimator.SetTrigger("duck");
    }

    public void SetTurnSpeed(float speed)
    {
        playerAnimator.SetFloat("turnSpeed", speed);
    }

    public void SetForwardSpeed(float speed)
    {
        playerAnimator.SetFloat("forwardSpeed", speed);
    }
}
