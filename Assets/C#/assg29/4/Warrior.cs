using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace as29
{
    public class Warrior : MonoBehaviour, ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }
}