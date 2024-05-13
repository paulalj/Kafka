using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanerolaMovement : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public float playerSpeed;
    public float gravity = 80f;
    public float fallVelocity;
    public float jumpForce;

    public CharacterController player;
    public Camera mainCamera;

    private Vector3 playerInput;
    private Vector3 movePlayer;
    private Vector3 camDelante;
    private Vector3 camDerecha;

    private Animator animator;

    private void Start()
    {
        player = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePlayer = playerInput.x * camDerecha + playerInput.z * camDelante;

        movePlayer = movePlayer * playerSpeed;

        player.transform.LookAt(player.transform.position + movePlayer);

        SetGravity();

        Jump();

        if (fallVelocity < 0)
        {
            animator.SetBool("Saltar", false);
        }

        player.Move(movePlayer * Time.deltaTime);

        if (horizontalMove > 0 || verticalMove > 0)
        {
            animator.SetBool("Caminar", true);
        }
        else
        {
            animator.SetBool("Caminar", false);
        }
    }

    private void camDirection()
    {
        camDelante = mainCamera.transform.forward;
        camDerecha = mainCamera.transform.right;

        camDelante.y = 0;
        camDerecha.y = 0;

        camDelante = camDelante.normalized;
        camDerecha = camDerecha.normalized;
    }

    public void Jump()
    {
        if (player.isGrounded && Input.GetButtonDown("Jump"))
        {
            fallVelocity = jumpForce;
            movePlayer.y = fallVelocity;
            animator.SetBool("Saltar", true);
        }
    }

    private void SetGravity()
    {
        if (player.isGrounded)
        {
            fallVelocity = -gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
        else
        {
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
    }
}
