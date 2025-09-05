using UnityEngine;
using UnityEngine.InputSystem;

public class flying : MonoBehaviour
{
    private float speed = 1.5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.linearVelocity += Vector2.up * speed;
        }
    }
}
