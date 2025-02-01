using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ass35
{

    public class DerivedClassExample : AbstractBaseClass
    {
        public override void PerformAction()
        {
            Debug.Log("The PerformAction method has been implemented in the derived class.");
        }
    }

}