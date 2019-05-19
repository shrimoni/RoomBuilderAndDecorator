using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RoomDecor.Wall;

namespace RoomDecor.Room
{
    public class RoomManager : MonoBehaviour
    {
        public static RoomManager Instance;

        // Awakes this instance
        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }

        // Creates the room the given the wall points
        public void CreateRoom(List<Vector2> wallPoints)
        {
            for(var i = 0;i<wallPoints.Count;i++)
            {
                if(i != wallPoints.Count - 1)
                {
                    WallManager.Instance.CreateWall(wallPoints[i], wallPoints[i + 1]);
                }
                else
                {
                    WallManager.Instance.CreateWall(wallPoints[i], wallPoints[0]);
                }
            }
        }
    }
}
