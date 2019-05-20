using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager
{

    // On Wall Height Changed
    public delegate void WallHeightChange(float heightValue);
    public static event WallHeightChange OnWallHeightChanged;

    // On Changed the wall height 
    public static void OnChangeWallHeight(float heightValue)
    {
        OnWallHeightChanged?.Invoke(heightValue);
    }
}
