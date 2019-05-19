using UnityEngine;

using RoomDecor.Asset;

namespace RoomDecor.Wall
{
    public class WallManager : MonoBehaviour
    {
        // Singleton
        public static WallManager Instance;

        // Wall Prefab
        public GameObject wallPrefab;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }

        /// <summary>
        /// Creates the Wall
        /// </summary>
        /// <param name="pointA"></param>
        /// <param name="pointB"></param>
        public void CreateWall(Vector2 pointA, Vector2 pointB)
        {
            /*
            var point = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            point.transform.position = new Vector3(pointA.x,0f,pointA.y);
            point = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            point.transform.position = new Vector3(pointB.x, 0f, pointB.y);*/
            
            var wall = Instantiate(wallPrefab);
            var wallAsset = wall.GetComponent<WallAsset>();
            var leftPoint = new Vector3(pointA.x, 0f, pointA.y);
            var rightPoint = new Vector3(pointB.x, 0f, pointB.y);

            wallAsset.LeftPoint = leftPoint;
            wallAsset.RightPoint= rightPoint;
            
        }
    }
}
