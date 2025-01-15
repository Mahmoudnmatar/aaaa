using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

namespace as29
{
    public class CustomObject
    {
        public int ID { get; private set; }

        public string Name { get; set; }


        public CustomObject(int id, string name)
        {

            ID = id;
            Name = name;
        }


        public override string ToString()
        {
            return "Object [ID: " + ID + " Name: " + Name + "]";
        }


        public override bool Equals(object obj)
        {
            if (obj is CustomObject other)
            {

                return ID == other.ID && Name == other.Name;
            }
            return false;
        }



    }
}