using UnityEngine;
using System.Collections;

public class MoleLifetime : MonoBehaviour
{
    public float duration = 5;
    float startTime;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
		// Destroy after 'duration' time has passed.
        if (startTime + duration < Time.time)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Score!");
		// Destroy projectile
        Destroy(collision.collider.gameObject);

		// Destroy us.
        Destroy(gameObject);
    }
}