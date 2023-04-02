using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterController characterController;
    public Animator animator;
    public bool groundedCharacter;
    float xMovement;
    float zMovement;
    public float verticalSpeed = 0f;
    public float shift = 0f;
    public float speed = 5f;
    public float jumpDelay;
    const float jumpDelayTime = 0.5f;
    const float gravity = -450f;
    const float jumpForce = 150f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        characterController.minMoveDistance = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Recogemos los inputs
        xMovement = Input.GetAxis("Horizontal");
        zMovement = Input.GetAxis("Vertical");

        //Creamos un vector de la direccion hacia donde nos movemos
        Vector3 directionMovement = Quaternion.Euler(0, transform.localEulerAngles.y, 0) * (Vector3.forward * zMovement + Vector3.right * xMovement);

        //Vemos si el personaje está en el suelo
        groundedCharacter = characterController.isGrounded;

        //Reseteamos la velocidad vertical si tocamos el suelo
        if (groundedCharacter)
        {
            verticalSpeed = 0f;
        }

        bool isWalking = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
        animator.SetBool("isWalking", isWalking);
        

        //Controlar el delay del salto
        if (jumpDelay > 0)
        {
            jumpDelay -= Time.deltaTime;
            if (jumpDelay <= 0)
            {
                verticalSpeed += jumpForce;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            //Modificaciones si pulsamos shift (correr)
            speed += 10f * Time.deltaTime;
            speed = Mathf.Min(speed, 10);
            animator.SetBool("isRunning", true);

        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            //Modificaciones si pulsamos control (agacharse)
            //animator.SetBool("isCrouch", true);
            speed -= 10f * Time.deltaTime;
            speed = Mathf.Max(speed, 3);

        }
        else
        {
            if (Mathf.Abs(5 - speed) < 10f * Time.deltaTime)
            {
                speed = 5f;
            }
            else
            {
                speed -= Mathf.Sign(speed - 5f) * 10f * Time.deltaTime;
            }
            animator.SetBool("isRunning", false);
            //animator.SetBool("isCrouch", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && groundedCharacter && jumpDelay <= 0)
        {
            //Modificacion para el salto
            jumpDelay = jumpDelayTime;
            speed = 0f;
            animator.SetBool("isJumping", true);
        }
        else
        {
            speed = 5f;
            animator.SetBool("isJumping", false);
        }


        //Añadir gravedad
        verticalSpeed += gravity * Time.deltaTime;
        directionMovement.y += verticalSpeed * Time.deltaTime;

        //Añadimos movimiento al personaje
        characterController.Move(directionMovement * speed * Time.deltaTime);
    }

}
