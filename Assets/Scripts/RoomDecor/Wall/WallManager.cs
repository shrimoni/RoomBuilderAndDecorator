using UnityEngine;
using UnityEngine.UI;

using RoomDecor.Asset;

namespace RoomDecor.Wall
{
    public class WallManager : MonoBehaviour
    {
        // Singleton
        public static WallManager Instance;

        // Wall Prefab
        public GameObject wallPrefab;

        [Header("Wall UI Elements")]
        public Slider wallHeightSlider;

        [SerializeField]private float wallHeight;

        // Wall Height
        public float WallHeight
        {
            get
            {
                return wallHeight;
            }
            set
            {
                wallHeight = value;
                EventManager.OnChangeWallHeight(wallHeight);
            }
        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
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
            var leftPointPos = new Vector3(pointA.x, 0f, pointA.y);
            var rightPointPos = new Vector3(pointB.x, 0f, pointB.y);

            var leftPoint = new GameObject("Left Point");
            leftPoint.transform.position = leftPointPos;
            var rightPoint = new GameObject("Right Point");
            rightPoint.transform.position = rightPointPos;

            wallAsset.LeftPoint = leftPoint.transform;
            wallAsset.RightPoint= rightPoint.transform;
            ChangeWallHeight();
            
        }

        // Change the wall height based on wall slider value 
        public void ChangeWallHeight()
        {
            Debug.Log(wallHeightSlider.value);
            WallHeight = wallHeightSlider.value;// 9ft wall height
        }
    }
}
