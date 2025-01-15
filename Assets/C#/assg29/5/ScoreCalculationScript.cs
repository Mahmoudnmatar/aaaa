using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace as29
{
    public class ScoreCalculationScript : MonoBehaviour
    {
        void Start()
        {
            int playerScore = 100;
            int divisor = 0;
            try
            {
                Debug.Log("Attempting to calculate score multiplier...");

                int totalScore = playerScore / divisor;

                Debug.Log("Total Score: " + totalScore);
            }
            catch (System.DivideByZeroException ex)
            {
                Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }
    }
}