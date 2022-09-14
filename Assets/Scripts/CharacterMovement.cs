using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;
    public float rotationSensitivity = 100f;
    public Transform player;

    private float rotationX = 0f;


    void Update()
    {
        // Rotation aka Look-Around
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * rotationSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSensitivity;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        player.Rotate(Vector3.up * mouseX);


        // Translation
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveVector = player.forward * moveZ + player.right * moveX;

        controller.Move(moveVector * Time.deltaTime * speed);
    }
}
