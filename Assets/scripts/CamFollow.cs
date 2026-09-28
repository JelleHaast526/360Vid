using UnityEngine;

public class FollowCameraPosition : MonoBehaviour
{
    [Tooltip("Drag your Main Camera or XR Camera here")]
    public Transform targetCamera;

    void LateUpdate()
    {
        if (targetCamera != null)
        {
            // Match the camera's position exactly, but leave rotation untouched
            transform.position = targetCamera.position;
        }
    }
}