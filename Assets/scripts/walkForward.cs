using UnityEngine;

public class RobotLoopMove : MonoBehaviour
{
    [Tooltip("How fast the robot walks forward")]
    public float speed = 3.5f;

    [Tooltip("Distance to walk before looping back")]
    public float distance = 30f;

    private Vector3 startPosition;

    void Start()
    {
        // Remember where the robot started
        startPosition = transform.position;
    }

    void Update()
    {
        // Move forward along its local Z axis
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Check how far it has traveled from the start
        float distanceTraveled = Vector3.Distance(startPosition, transform.position);

        // If it reaches the target distance, loop back to the start
        if (distanceTraveled >= distance)
        {
            transform.position = startPosition;
        }
    }
}