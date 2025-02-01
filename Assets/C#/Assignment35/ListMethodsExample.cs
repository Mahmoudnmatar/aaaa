using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ass35
{
    public class ListMethodsExample : MonoBehaviour
    {

        void Start
        {


            // ex 4
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };


            numbers.Sort((x, y) => y.CompareTo(x)) ;

            string sortedList = string.Join(", ", numbers);

            Debug.Log("Sorted List : " + sortedList);

            // ex 5


            List<int> numbers2 = new List<int> { 10, 21, 32, 45, 56, 67, 78, 89, 90 };

            List<int> filteredNumbers = numbers2.FindAll(x => x % 2 == 0);

            string filteredList = string.Join(", ", filteredNumbers);
            Debug.Log("Filtered List (Even Numbers): " + filteredList);
        }
    }
}