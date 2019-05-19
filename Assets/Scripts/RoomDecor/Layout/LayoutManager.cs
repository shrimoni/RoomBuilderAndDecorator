using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RoomDecor.Room;

namespace RoomDecor.Layout
{
    public class LayoutManager : MonoBehaviour
    {
        [SerializeField] private LayoutData rectangularShapeLayout;
        [SerializeField] private LayoutData lShapeLayout;
        [SerializeField] private LayoutData tShapeLayout;
        [SerializeField] private LayoutData zShapeLayout;
        [SerializeField] private LayoutData freeShapeLayout;
        [SerializeField] private LayoutData randomShapedRoom;

        private void Awake()
        {
            Initialize();
        }

        void Initialize()
        {
            AddRectangularShapeLayoutData();
            AddLShapeLayoutData();
            AddRandomShapeRoomData();
            AddTShapeLayoutData();
            AddZShapeLayoutData();
        }

        // Creates the layout
        public void CreateLayout(int index)
        {
            var layoutType = (LayoutType)index;
            switch(layoutType)
            {
                case LayoutType.RECTANGULAR:
                    Debug.Log("Rectangular Layout");
                    RoomManager.Instance.CreateRoom(rectangularShapeLayout.wallPoints);
                    break;
                case LayoutType.LSHAPE:
                    Debug.Log("LShaped Layout");
                    RoomManager.Instance.CreateRoom(lShapeLayout.wallPoints);
                    break;
                case LayoutType.TSHAPE:
                    Debug.Log("TShaped Layout");
                    RoomManager.Instance.CreateRoom(tShapeLayout.wallPoints);
                    break;
                case LayoutType.ZSHAPE:
                    Debug.Log("ZShaped Layout");
                    RoomManager.Instance.CreateRoom(zShapeLayout.wallPoints);
                    break;
                case LayoutType.USERDEFINED:
                    Debug.Log("Rectangular Layout");
                    RoomManager.Instance.CreateRoom(randomShapedRoom.wallPoints);
                    break;
                default:
                    break;
            }
        }

        // Adds the wall points data for rectangular data
        void AddRectangularShapeLayoutData()
        {
            rectangularShapeLayout.layoutType = LayoutType.RECTANGULAR;
            rectangularShapeLayout.wallPoints.Add(new Vector2(-4f, -2f));
            rectangularShapeLayout.wallPoints.Add(new Vector2(-4f, 2f));
            rectangularShapeLayout.wallPoints.Add(new Vector2(4f, 2f));
            rectangularShapeLayout.wallPoints.Add(new Vector2(4f, -2f));
        }

        // Adds the wall points data for LShaped Layout
        void AddLShapeLayoutData()
        {
            lShapeLayout.layoutType = LayoutType.LSHAPE;
            lShapeLayout.wallPoints.Add(new Vector2(-2f, -2f));
            lShapeLayout.wallPoints.Add(new Vector2(-2f, 2f));
            lShapeLayout.wallPoints.Add(new Vector2(0f, 2f));
            lShapeLayout.wallPoints.Add(new Vector2(0f, 0f));
            lShapeLayout.wallPoints.Add(new Vector2(2f, 0f));
            lShapeLayout.wallPoints.Add(new Vector2(2f, -2f));
        }

        // Adds the wall points data for TShaped Layout
        void AddTShapeLayoutData()
        {
            tShapeLayout.layoutType = LayoutType.TSHAPE;
            tShapeLayout.wallPoints.Add(new Vector2(-2f, -2f));
            tShapeLayout.wallPoints.Add(new Vector2(-2f, 0f));
            tShapeLayout.wallPoints.Add(new Vector2(-4f, 0f));
            tShapeLayout.wallPoints.Add(new Vector2(-4f, 2f));
            tShapeLayout.wallPoints.Add(new Vector2(4f, 2f));
            tShapeLayout.wallPoints.Add(new Vector2(4f, 0f));
            tShapeLayout.wallPoints.Add(new Vector2(2f, 0f));
            tShapeLayout.wallPoints.Add(new Vector2(2f, -2f));
        }

        void AddZShapeLayoutData()
        {
            zShapeLayout.layoutType = LayoutType.ZSHAPE;
            zShapeLayout.wallPoints.Add(new Vector2(-2f, -2f));
            zShapeLayout.wallPoints.Add(new Vector2(-2f, 0f));
            zShapeLayout.wallPoints.Add(new Vector2(-4f, 0f));
            zShapeLayout.wallPoints.Add(new Vector2(-4f, 2f));
            zShapeLayout.wallPoints.Add(new Vector2(0f, 2f));
            zShapeLayout.wallPoints.Add(new Vector2(0f, 0f));
            zShapeLayout.wallPoints.Add(new Vector2(2f, 0f));
            zShapeLayout.wallPoints.Add(new Vector2(2f, -2f));

        }

        void AddRandomShapeRoomData()
        {
            randomShapedRoom.layoutType = LayoutType.USERDEFINED;
            randomShapedRoom.wallPoints.Add(new Vector2(-2f, -2f));
            randomShapedRoom.wallPoints.Add(new Vector2(-2f, 0f));
            randomShapedRoom.wallPoints.Add(new Vector2(0f, 2f));
            randomShapedRoom.wallPoints.Add(new Vector2(0f, 0f));
            randomShapedRoom.wallPoints.Add(new Vector2(2f, 0f));
            randomShapedRoom.wallPoints.Add(new Vector2(2f, -2f));
        }
    }
}
