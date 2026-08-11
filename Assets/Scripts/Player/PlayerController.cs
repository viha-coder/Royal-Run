using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float xClamp = 5f;
    [SerializeField] private float zClamp = 5f;

    private float timeValue = 0f;

    Vector2 movement;
    Rigidbody rb;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate() 
    {
        HandleMovement();
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement= context.ReadValue<Vector2>();
    }

    private void HandleMovement()
    {
        Vector3 CurrentPosition = rb.position;
        Vector3 moveDirection = new Vector3(movement.x, 0f, movement.y);
        Vector3 newPosition = CurrentPosition + moveDirection * (moveSpeed * Time.fixedDeltaTime);

        newPosition.x = Mathf.Clamp(newPosition.x, -xClamp, xClamp);
        newPosition.z = Mathf.Clamp(newPosition.z, -zClamp, zClamp);

        rb.MovePosition(newPosition);
    }


}
