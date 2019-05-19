using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RoomDecor.Asset
{
    [RequireComponent(typeof(MeshCollider))]
    public abstract class RoomDecorAsset : MonoBehaviour
    {
        public abstract string AssetName { get; set; }

        public abstract Vector3 Location { get; set; }

        public abstract Vector3 RotationEuler { get; set; }

        public abstract Vector3 Scale { get; set; }
    }
}
