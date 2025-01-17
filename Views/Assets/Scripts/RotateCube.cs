using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField]
    private float xSpeed = 10f; // Rotation speed around the X-axis

    [SerializeField]
    private float ySpeed = 15f; // Rotation speed around the Y-axis

    [SerializeField]
    private float zSpeed = 20f; // Rotation speed around the Z-axis

    void Update()
    {
        // Calculate rotation for each axis
        float xRotation = xSpeed * Time.deltaTime;
        float yRotation = ySpeed * Time.deltaTime;
        float zRotation = zSpeed * Time.deltaTime;

        // Apply rotation
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
