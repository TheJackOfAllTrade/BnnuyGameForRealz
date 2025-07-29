using UnityEngine;
using UnityEngine.InputSystem;

public class NewPlayerHandler : MonoBehaviour
{
    public InputActionAsset InputActions;
    
    private InputAction moveAction;

    private Vector2 movementAmount;
    private Rigidbody2D playerRigidBody;

    public float moveSpeed = 5f;


    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movementAmount = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        playerRigidBody.MovePosition(playerRigidBody.position + movementAmount * moveSpeed * Time.deltaTime);
    }
}

