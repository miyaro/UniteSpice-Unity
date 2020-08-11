using UnityEngine;

namespace CompleteProject
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;            // The position that that camera will be following.
        public float smoothing = 5f;        // The speed with which the camera will be following.


        private Vector3 offset;                     // The initial offset from the target.

        void Start ()
        {
            if (target == null)
                return;
            
            // Calculate the initial offset.
            offset = transform.position - target.position;
        }

        void LateUpdate()
        {
            if (target == null)
                return;
            
            // Create a postion the camera is aiming for based on the offset from the target.
            var targetCamPos = target.position + offset;

            // Smoothly interpolate between the camera's current position and it's target position.
            transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
        }


        public void SetTarget (Transform _target)
        {
            target = _target;
        }

        public void SetTarget (Vector2 _point)
        {
            this.transform.position = new Vector3(_point.x, _point.y, -10);
        }

    }
}