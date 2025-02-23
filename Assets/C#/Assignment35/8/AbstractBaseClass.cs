using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ass35
{

    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();

        public void PrintInfo()
        {
            Debug.Log("This is a concrete method from the abstract base class.");
        }
    }
}