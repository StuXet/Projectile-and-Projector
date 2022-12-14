using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float sensitivity = 100.0f;

    void Update()
    {
        // Get the horizontal and vertical axis values from the mouse
        float horizontal = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float vertical = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Calculate the direction in which the player should be facing
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // Rotate the player to face the direction calculated above
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
