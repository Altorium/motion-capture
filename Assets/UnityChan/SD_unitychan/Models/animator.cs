using UnityEngine;

public class caracter : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    public float jumpPower = 300f;
    private float speed = 50f;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.forward * speed, ForceMode.Acceleration);
            animator.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.forward * speed, ForceMode.Acceleration);
            animator.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(transform.right * speed, ForceMode.Acceleration);
            animator.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-transform.right * speed, ForceMode.Acceleration);
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Run", false);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
