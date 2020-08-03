using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float moveSpeed = 1.0f;
    private float angularSpeed = 1.0f;
    private float rotationAngle = 0f;
    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            moveSpeed += 0.05f;
        else if (Input.GetKey(KeyCode.S))
            moveSpeed -= 0.05f;

        // rotating the sight
        float mouse_x = Input.GetAxis("Mouse X");
        rotationAngle += mouse_x * angularSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, rotationAngle, 0));

        Vector3 direction = transform.TransformDirection(Vector3.forward * Time.deltaTime * moveSpeed);
        characterController.Move(direction);
    }
}
