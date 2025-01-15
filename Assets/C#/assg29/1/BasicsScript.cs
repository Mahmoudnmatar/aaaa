using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace as29
{
    public class BasicsScript : MonoBehaviour
    {

        void Start()
        {
            var num = 5;
            var text = "matar";
            var isActive = true;

            string evenOrOdd = (num % 2 == 0) ? "even  " : "   odd";

            Debug.Log("the number is : " + num + evenOrOdd);
            Debug.Log("Current Data  :" + System.DateTime.Now.Date);
            Debug.Log("Current Time : " + System.DateTime.Now.TimeOfDay);

            Debug.Log("Current Day : " + System.DateTime.Now.DayOfWeek);



        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}