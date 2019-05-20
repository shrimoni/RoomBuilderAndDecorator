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
        [SerializeField]private Transform leftPoint;
        [SerializeField]private Transform rightPoint;

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
        public Transform LeftPoint
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
        public Transform RightPoint
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

        private void OnEnable()
        {
            EventManager.OnWallHeightChanged += SetWallHeight;
        }

        private void OnDisable()
        {
            EventManager.OnWallHeightChanged -= SetWallHeight;
        }

        void Initialize()
        {
            SetLocation();
            SetRotation();
            SetScale();
            SetLeftRightParent();
        }

        // Sets the Location
        void SetLocation()
        {
            Location = MathUtilities.GetMidPoint(leftPoint.position, rightPoint.position);
        }

        // Sets the rotation
        void SetRotation()
        {
            transform.right = (leftPoint.position - transform.position).normalized;
            RotationEuler = transform.eulerAngles;
        }

        // Sets the scale
        void SetScale()
        {
            var scale = transform.localScale;
            scale.x = MathUtilities.DistanceBetweenTwoPoints(leftPoint.position, rightPoint.position);
            Scale = scale;
        }

        void SetLeftRightParent()
        {
            if(leftPoint != null && rightPoint != null)
            {
                leftPoint.SetParent(this.transform, true);
                rightPoint.SetParent(this.transform, true);
            }
        }

        // Sets the wall height
        void SetWallHeight(float wallHeight)
        {
            var scale = Scale;
            scale.y = wallHeight;
            Scale = scale;
        }
    }
}
