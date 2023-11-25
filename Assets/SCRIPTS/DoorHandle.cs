using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoorController : MonoBehaviour
{
    public float doorOpenAngle = 90f; // The angle the door opens
    public bool isOpen = false; // To track whether the door is open or not

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0)) // 0 corresponds to the left mouse button
        {
            // Toggle the door state
            if (isOpen)
            {
                CloseDoor();
            }
            else
            {
                OpenDoor();
            }
        }
    }

    void OpenDoor()
    {
        // Rotate the door to the open angle
        transform.rotation = Quaternion.Euler(0, doorOpenAngle, 0);
        isOpen = true;
    }

    void CloseDoor()
    {
        // Rotate the door back to the closed angle
        transform.rotation = Quaternion.Euler(0, 0, 0);
        isOpen = false;
    }
}

