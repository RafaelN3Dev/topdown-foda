using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager
{
    private InputControls inputControls;

    //public Vector2 InputDirection => InputControls.Player.Move.ReadValue<Vector2>();

    public InputManager()
    {
        inputControls = new InputControls();
        inputControls.Enable();
    }

    public Vector2 GetInputDirection()
    {
        return inputControls.Player.Move.ReadValue<Vector2>();
    }

    public void DisableInput()
    {

    }
}
