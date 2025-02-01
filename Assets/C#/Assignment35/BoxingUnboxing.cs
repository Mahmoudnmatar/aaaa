using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ass35
{
    public class BoxingUnboxing : MonoBehaviour
    {



        void Start()
        {
            int health = 100;

            object boxed = health;
            Debug.Log("boxed health = " + boxed);

            int unBoxed = (int)boxed;

            unBoxed += 10;

            Debug.Log("unBoxed health = " + unBoxed);



        }

        void Update()
        {

        }
    }
}