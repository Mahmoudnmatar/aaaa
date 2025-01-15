using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace as29
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            int n1 = 10;
            int n2 = 30;

            Debug.Log("Recursive Fibonacci of " + n1 + ": " + FibonacciRecursive(n1));
            Debug.Log("Recursive Fibonacci of " + n2 + ": " + FibonacciRecursive(n2));
        }

        int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return b;
        }
    }
}