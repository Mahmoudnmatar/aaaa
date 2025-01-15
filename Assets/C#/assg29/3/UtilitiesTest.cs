using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace as29
{
    public class UtilitiesTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int sum = Utilities.Add(1, 2, 3, 4, 5);
            Debug.Log("Sum of numbers: " + sum);  // Should log: "Sum of numbers: 15"

            // Testing the RepeatString extension method
            string repeatedString = "Hello".RepeatString(3);
            Debug.Log("Repeated string: " + repeatedString);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}