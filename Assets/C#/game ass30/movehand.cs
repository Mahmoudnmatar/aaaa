using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movehand : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 input;
    bool jump = false;

    float handSpeed = 50f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
        rigidbody.mass = 5; // Adjusted for smoother movement
    }

    void Update()
    {
        // Capture input for horizontal and vertical movement
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        input = input.normalized * handSpeed;

        if (Input.GetKeyDown(KeyCode.Space)) // Explicit jump trigger
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        if (jump)
        {
            rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
            jump = false; // Reset jump
        }
        else
        {
            // Use MovePosition for smoother physics interactions
            rigidbody.MovePosition(rigidbody.position + input * Time.fixedDeltaTime);
        }
    }
}
