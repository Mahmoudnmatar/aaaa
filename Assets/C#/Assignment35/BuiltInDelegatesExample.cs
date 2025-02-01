using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ass35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Action logMassage = () => Debug.Log("Action Delegate");

            logMassage();

            Func<int, int> square = number => number * number;

            Debug.Log($"Square: {square(5)}");

            Predicate<int> isEven = number => number % 2 == 0;
            Debug.Log($"Is number even {isEven(4)} ");

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}