using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assh25
{
    public class spring : MonoBehaviour
    {
        float minScale = 0.05f;
        float maxScale = 3f;

        float scaleFactor = 4;


        void Start()
        {
            scaleFactor = minScale;
            // transform.GetChild(0).gameObject.SetActive(false);
        }
        void Update()
        {
            if (Input.GetKey(KeyCode.A)) // Left
            {
                // transform.GetChild(0).gameObject.SetActive(true);
                scaleFactor -= Time.deltaTime ;
            }

            else if (Input.GetKey(KeyCode.D)) // Right
            {
                // transform.GetChild(0).gameObject.SetActive(true);
                scaleFactor += Time.deltaTime * 9;
            }
            scaleFactor = Mathf.Clamp(scaleFactor, minScale, maxScale);

            transform.localScale = new Vector3(scaleFactor / 2, scaleFactor, scaleFactor / 2);
        }
    }
}
