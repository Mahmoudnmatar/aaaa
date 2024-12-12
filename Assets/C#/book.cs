using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assg25
{
    public class Book : MonoBehaviour
    {
        public float openBookSpeed = 100;
        float bookAngle = 0;

        void Update()
        {
            if (Input.GetKey(KeyCode.D)) // Right
            {
                bookAngle -= 5 * Time.deltaTime * openBookSpeed;
                RotateBookCover();
            }
            else if (Input.GetKey(KeyCode.A)) // Left
            {
                bookAngle += 5 * Time.deltaTime * openBookSpeed;
                RotateBookCover();
            }
        }

        private void RotateBookCover()
        {
            bookAngle = Mathf.Clamp(bookAngle, -180, 0);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, bookAngle));
            // Debug.Log(transform.rotation.eulerAngles.z);
        }
    }
}