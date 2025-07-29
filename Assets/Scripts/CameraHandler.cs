using UnityEngine;
using UnityEngine.Rendering;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;
    [SerializeField] private float smoothTime = 0.25f;
    [SerializeField] private Vector3 offset;
    private Vector2 velocity = Vector2.zero;

    private void FixedUpdate()
    {
        Vector2 targetPosition = cameraTarget.position;
        targetPosition = Vector2.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        transform.position = new Vector3(targetPosition.x, targetPosition.y, offset.z);
    }
}
