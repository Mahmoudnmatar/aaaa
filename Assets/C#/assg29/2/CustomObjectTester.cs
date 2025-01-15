using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace as29
{
    public class CustomObjectTester : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

            CustomObject customObject = new CustomObject(5, "matar");

            print(customObject.ToString());


            CustomObject customObject1 = new CustomObject(10, "mego");
            print(customObject == customObject1);
            print(customObject != customObject1);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}