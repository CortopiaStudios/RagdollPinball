using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    void Update()
    {
        // Get the mouse position in world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Only use the x and z coordinates (keep the object level on the y-axis)
        mousePosition.y = transform.position.y;

        // Calculate the direction from the object to the mouse position
        Vector3 direction = mousePosition - transform.position;

        // Calculate the rotation needed to face the mouse position
        Quaternion rotation = Quaternion.LookRotation(direction);

        // Apply the rotation on the y-axis only
        transform.rotation = Quaternion.Euler(0, rotation.eulerAngles.y, 0);
    }
}
