// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     [Header("Movement")]
//     public float movementSpeed;
    
//     public float groundDrag;

//     [Header("Ground Check")]
//     public float playerHeight;
//     public LayerMask Ground;
//     bool grounded;
    
//     public Transform orientation;

//     float xInput;
//     float yInput;

//     Vector3 movementDireciton;

//     Rigidbody rb;
//     // Start is called before the first frame update
//     void Start()
//     {
//         rb = GetComponent<Rigidbody>();
//         rb.freezeRotation = true;   
//     }

//     private void PlayerInput()
//     {
//         xInput = Input.GetAxisRaw("Horizontal");
//         yInput = Input.GetAxisRaw("Vertical");
//     }
    
//     private void MovePlayer()
//     {
//         // Calculates movement directions
//         movementDireciton = orientation.forward * yInput + orientation.right * xInput;
//         rb.AddForce(movementDireciton.normalized * movementSpeed * 10f, ForceMode.Force);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, Ground);
//         PlayerInput();

//         if (grounded)
//         {
//         rb.drag = groundDrag;
//         }
//         else
//         {
//             rb.drag = 0;
//         }
//     }

//     private void FixedUpdate()
//     {
//         MovePlayer();    
//     }



// }
