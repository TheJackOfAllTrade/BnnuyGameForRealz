using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private SpriteRenderer bgSpriteRenderer;
    [SerializeField] private float playerSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
    }
}
