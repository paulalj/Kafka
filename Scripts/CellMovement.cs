using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CellMovement : MonoBehaviour
{
    private float speed = 3;
    private Vector3 dreta = new Vector3(0f, 90f, 0f);
    private Vector3 esque = new Vector3(0f, -90f, 0f);
    private Vector3 abaix = new Vector3(0f, 180f, 0f);
    private Vector3 adalt = Vector3.zero;
    private Vector3 ada_dre = new Vector3(0f, 45f, 0f);
    private Vector3 dre_aba = new Vector3(0f, 135f, 0f);
    private Vector3 esq_aba = new Vector3(0f, -135, 0f);
    private Vector3 esq_ada = new Vector3(0f, -45f, 0f);

    private Animator animator;

    CharacterController cc;

    private void Awake()
    {
        cc=GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 movementInput = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementInput.z = 1;
            animator.SetBool("Caminar", true);
            transform.rotation = Quaternion.Euler(adalt);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            movementInput.z = 0;
            animator.SetBool("Caminar", false);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            movementInput.z = -1;
            animator.SetBool("Caminar", true);
            transform.rotation = Quaternion.Euler(abaix);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            movementInput.z = 0;
            animator.SetBool("Caminar", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementInput.x = 1;
            animator.SetBool("Caminar", true);
            transform.rotation = Quaternion.Euler(dreta);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            movementInput.z = 0;
            animator.SetBool("Caminar", false);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementInput.x = -1;
            animator.SetBool("Caminar", true);
            transform.rotation = Quaternion.Euler(esque);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            movementInput.z = 0;
            animator.SetBool("Caminar", false);
        }

        if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(ada_dre);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(dre_aba);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(esq_aba);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(esq_ada);
        }

        cc.SimpleMove(movementInput.normalized * speed);
    }
}
