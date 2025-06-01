using System.Diagnostics;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;

public class caracter : MonoBehaviour
{
    Rigidbody rb;
    private Rigidbody rigidBody;
    private Animator animator;
    private float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddForce(transform.forward * speed, ForceMode.Acceleration);
            animator.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.AddForce(transform.forward * speed * -1, ForceMode.Acceleration);
            animator.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(transform.right * speed, ForceMode.Acceleration);
            animator.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(transform.right * speed * -1, ForceMode.Acceleration);
            animator.SetBool("Run", true);

        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Run", false);
        }
    }
}