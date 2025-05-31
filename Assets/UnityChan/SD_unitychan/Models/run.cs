using UnityEngine;

public class PlayerController3D : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // ←→キー
        float moveZ = Input.GetAxisRaw("Vertical");   // ↑↓キー

        // 入力ベクトルを作成
        movement = new Vector3(moveX, 0f, moveZ).normalized;
    }

    void FixedUpdate()
    {
        // 毎フレーム、移動させる
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}