using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LayoutType
{
    RECTANGULAR = 0,
    LSHAPE = 1,
    TSHAPE = 2,
    ZSHAPE = 3,
    USERDEFINED = 4
}

namespace RoomDecor.Layout
{
    [System.Serializable]
    public class LayoutData
    {
        public LayoutType layoutType;
        public List<Vector2> wallPoints = new List<Vector2>();
    }
}
