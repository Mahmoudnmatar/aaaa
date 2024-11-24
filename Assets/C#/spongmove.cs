using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class spongmove : MonoBehaviour
{
    public Vector3 move = new Vector3(0, 0, 0);

    public float x = 1f;
    public float y = 1f;

    public float deg = 1f;
    public float angleInc = 1f;



    void Start()
    {


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            transform.position += new Vector3(x, 0, 0);
            //move += Vector3.forward;|
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(-x, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            deg += angleInc;
            transform.rotation = Quaternion.Euler(new Vector3(0, y * deg, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            deg -= angleInc;

            transform.rotation = Quaternion.Euler(new Vector3(0, y * deg, 0));

        }





    }
}
