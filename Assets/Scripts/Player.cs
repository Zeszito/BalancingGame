using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;

    //FUTURE i want to make the ball fall

    

    // Update is called once per frame
    void Update()
    {
        RotatePlate();
    }

    private void RotatePlate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        print("X Value " + mouseX);
        print("Y Value" + mouseY);



        float rotationX = mouseX * rotationSpeed;
        float rotationY = mouseY * rotationSpeed;

       transform.Rotate(Vector3.forward * rotationX);
       transform.Rotate(Vector3.right * rotationY);
    }

    private void OnMouseDown()
    {
        
    }
}
