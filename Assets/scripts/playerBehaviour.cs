using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    private InputManager inputManager;

    private Rigidbody2D rigidbody;

    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        inputManager = new InputManager();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody.linearVelocity = inputManager.GetInputDirection() * moveSpeed;
    }
       
    private void OnDisable()
    {
        inputManager.DisableInput();
    }

}
