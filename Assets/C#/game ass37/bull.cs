using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bull : MonoBehaviour
{

    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
        rigidbody.mass = 5;

    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        rigidbody.constraints = RigidbodyConstraints.FreezePositionY;


    }
}
