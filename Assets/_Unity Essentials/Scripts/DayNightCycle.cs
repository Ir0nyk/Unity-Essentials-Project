using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayLengthInSeconds = 120f; // Adjustable day length in seconds
    public Light directionalLight; // Reference to the Directional Light

    private float rotationSpeed;
    private float initialAngle;

    void Start()
    {
        // Calculate rotation speed based on day length
        rotationSpeed = 360f / dayLengthInSeconds;

        // Store initial light angle
        initialAngle = transform.eulerAngles.x;
    }

    void Update()
    {
        // Rotate light around its axis
        float angle = initialAngle + (Time.time * rotationSpeed);
        transform.eulerAngles = new Vector3(angle, 0f, 0f);
    }
}
