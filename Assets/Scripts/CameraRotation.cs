using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraRotation : MonoBehaviour
{
    
    float maxRotation = 45f;
    float minRotation = -35f;

    public float rotationX = 0f;
    public float rotationY = 0f;

    Transform transformCamera;
    public Transform transformPlayer;

    float posX;
    float posY;

    public float sensibility;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        transformCamera = GetComponent<Transform>();
        sensibility = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensibility;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensibility;

        if (maxRotation - rotationY < mouseY)
        {
            mouseY = maxRotation - rotationY;
        }
        else if (minRotation - rotationY > mouseY)
        {
            mouseY = minRotation - rotationY;
        }

        rotationX += mouseX;
        rotationY += mouseY;

        posX = -mouseY;
        posY = mouseX;


        transformCamera.Rotate(posX, 0, 0);
        transformPlayer.Rotate(0, posY, 0);
    }
}
