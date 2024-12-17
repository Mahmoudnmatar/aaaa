using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assg27
{
    public class Assg27_referance : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

            int a = 4;
            int b = 2;


            CallByValue(a);

            Debug.Log("the value of A = " + a);

            CallByReferance(ref b);

            Debug.Log("the value of B  =  " + b);

            OutKey(out a) ;

            Debug.Log("the value of A* = " + a);



        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CallByValue(int number)
        {

            number += 10;

        }

        public void CallByReferance(ref int num)
        {

            num += 10;


        }


        public static  void OutKey(out int num)
        {

            num = 20;
        }
    }
}
