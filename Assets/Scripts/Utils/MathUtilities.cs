using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class MathUtilities
    {
        /// <summary>
        /// Calculates the midpoint of two given items
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector3 GetMidPoint(Vector3 a, Vector3 b)
        {
            var midPoint = (a + b) / 2f;
            return midPoint;
        }

        /// <summary>
        /// Returns the distance between two points
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float DistanceBetweenTwoPoints(Vector3 a, Vector3 b)
        {
            var distance = Vector3.Distance(a, b);
            return distance;
        }
    }
}
