using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private Vector3 startPosition = new Vector3();
    private Quaternion startRotation = new Quaternion();
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = rb.position;
        startRotation = rb.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ResetPosition();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "EndsGame")
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        rb.position = startPosition;
        rb.rotation = startRotation;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
