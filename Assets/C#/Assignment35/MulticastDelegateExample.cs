using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ass35
{
    public class MulticastDelegateExample : MonoBehaviour
    {
        // Start is called before the first frame update
        delegate void MathOperation(int number);

        void DoubleNumber(int number) => Debug.Log("Double number : " + number * 2);

        void SuqareNumber(int number) => Debug.Log("Suqare number :" + number * number);

        void CubeNumber(int number) => Debug.Log("Cube number :" + number * number * number);


        void Start()
        {

            MathOperation operation = null;


            operation += DoubleNumber;

            operation += SuqareNumber;

            operation += CubeNumber;


            operation(5);



        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}