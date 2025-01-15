using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace as29
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            Animal animal = new Cat();
            animal.MakeSound();
            animal.Move();

            Cat cat = animal as Cat;
            if (cat != null)
            {
                cat.MakeSound();
                cat.Move();
            }

            List<ICanFight> fighters = new List<ICanFight>
        {
            new Cat(),
            new Warrior()
        };

            foreach (ICanFight fighter in fighters)
            {
                if (fighter is Cat)
                {
                    Debug.Log("The object is a Cat.");
                    fighter.Attack();
                }
                else if (fighter is Warrior)
                {
                    Debug.Log("The object is a Warrior.");
                    fighter.Attack();
                }
            }

        }
        void Update()
        {

        }
    }
}