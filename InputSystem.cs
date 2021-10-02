using System.Linq;
using Unity.Mathematics;
using UnityEngine;

namespace ExhibitionUtils
{
    public class InputSystem
    {
        private bool lastIsTouching;
        private bool isTouching;
        private Touch? touch;

        public InputSystem()
        {

        }

        public void EarlyUpdate()
        {
            lastIsTouching = isTouching;
            isTouching = Input.touches.Any();
            touch = null;
            if (Input.touchCount > 0) {
                touch = Input.touches[0];
            }
        }

        public Vector3 PressedPosition()
        {
            if (touch.HasValue) {
                return math.float3(touch.Value.position, 0f);
            }
            return Input.mousePosition;
        }

        public bool IsJustPressedDown()
        {
            if (touch.HasValue) {
                return touch.Value.phase == TouchPhase.Began;
            }
            return Input.GetMouseButtonDown(0);
            // ||
            // (isTouching && !lastIsTouching);
        }

        public bool IsPressing()
        {
            return Input.GetMouseButton(0) || touch.HasValue;
        }

        public bool IsJustPressedUp()
        {
            if (touch.HasValue) {
                return touch.Value.phase == TouchPhase.Ended;
            }
            return Input.GetMouseButtonUp(0);
            // ||
            // (!isTouching && lastIsTouching);
        }

    }
}
