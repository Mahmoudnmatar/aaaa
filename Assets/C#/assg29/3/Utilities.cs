using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace as29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static string RepeatString(this string str, int times)
        {
            string result = string.Empty;
            for (int i = 0; i < times; i++)
            {
                result += str;
            }
            return result;
        }
    }
}