using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Utils;

namespace RoomDecor.Asset
{
    public class WallAsset : RoomDecorAsset
    {
        private string mAssetName;
        private Vector3 mLocation;
        private Vector3 mRotationEuler;
        private Vector3 mScale;
        private Vector3 leftPoint;
        private Vector3 rightPoint;

        public override string AssetName
        {
            get
            {
                return mAssetName;
            }
            set
            {
                mAssetName = value;
            }
        }
        public override Vector3 Location
        {
            get
            {
                return mLocation;
            }
            set
            {
                mLocation = value;
                transform.position = mLocation;
            }
        }
        public override Vector3 RotationEuler
        {
            get
            {
                return mRotationEuler;
            }
            set
            {
                mRotationEuler = value;
                transform.eulerAngles = mRotationEuler;
            }
        }
        public override Vector3 Scale
        {
            get
            {
                return mScale;
            }
            set
            {
                mScale = value;
                transform.localScale = mScale;
            }
        }
        public Vector3 LeftPoint
        {
            get
            {
                return leftPoint;
            }
            set
            {
                leftPoint = value;
            }
        }
        public Vector3 RightPoint
        {
            get
            {
                return rightPoint;
            }
            set
            {
                rightPoint = value;
                Initialize();
            }
        }

        void Initialize()
        {
            SetLocation();
            SetRotation();
            SetScale();
        }

        // Sets the Location
        void SetLocation()
        {
            Location = MathUtilities.GetMidPoint(leftPoint, rightPoint);
        }

        // Sets the rotation
        void SetRotation()
        {
            transform.right = (leftPoint - transform.position).normalized;
            RotationEuler = transform.eulerAngles;
        }

        // Sets the scale
        void SetScale()
        {
            var scale = transform.localScale;
            scale.x = MathUtilities.DistanceBetweenTwoPoints(leftPoint, rightPoint);
            Scale = scale;
        }
    }
}
