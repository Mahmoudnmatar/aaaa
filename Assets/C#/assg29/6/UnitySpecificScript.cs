using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace as29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        private GameObject targetObject;
        private GameObject jokerObject;
        private Light sceneLight;

        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }

        void Start()
        {
            print("Game started!");

            targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
            {
                print("Found object by name: " + targetObject.name);
            }
            else
            {
                print("No TargetObject found.");
            }

            jokerObject = GameObject.FindGameObjectWithTag("Joker");
            if (jokerObject != null)
            {
                print("Found object by tag: " + jokerObject.name);
            }
            else
            {
                print("No Joker object found.");
            }

            sceneLight = GameObject.FindObjectOfType<Light>();
            if (sceneLight != null)
            {
                print("Found object of type Light:" + sceneLight.name);
            }
            else
            {
                print("No Light object found.");
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D) && targetObject != null)
            {
                targetObject.SetActive(false);
                print("TargetObject deactivated!");
            }
        }
    }
}