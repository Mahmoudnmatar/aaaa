using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assg26
{


    public class Creature
    {

        public virtual void Speak()
        {
            Debug.Log("A Creature make sound");

        }

    }


    public interface IRunnable
    {
        void Run();
    }
    public interface IJumpable
    {
        void Jump();
    }
    public interface ISwimmable
    {
        void Swim();
    }



    public class Kangroo : Creature, IRunnable, IJumpable
    {

        public void Run()
        {

            Debug.Log("Kangroo Run");

        }
        public void Jump()
        {

            Debug.Log("Kangroo Jump");

        }

        public override void Speak()
        {
            Debug.Log("Kangroo says : Hop!");
        }

    }
    public class Duck : Creature, IRunnable, ISwimmable
    {

        public void Run()
        {

            Debug.Log("Duck Run");

        }
        public void Swim()
        {

            Debug.Log("Duck Swim");

        }

        public override void Speak()
        {
            Debug.Log("Duck says : Quack!");
        }

    }




}