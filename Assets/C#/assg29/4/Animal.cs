using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace as29
{
    public class Animal : MonoBehaviour
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }

        public void Move()
        {
            Debug.Log("Animal moves.");
        }
    }

    public class Cat : Animal, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }

        public void Move()
        {
            Debug.Log("Cat runs quickly.");
        }

        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }
    public interface ICanFight
    {
        void Attack();
    }
}



