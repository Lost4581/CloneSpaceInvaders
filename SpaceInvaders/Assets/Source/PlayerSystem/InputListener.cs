using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    [SerializeField] private PlayerMove playerMove;

    private InputSystem_Actions m_Actions;
    private Vector2 _value;
    
    private void Start()
    {
        m_Actions = new InputSystem_Actions();
        m_Actions.Player.Move.performed += LogicMove;
        m_Actions.Enable();
        _value = new Vector2();
    }

    private void LogicMove(InputAction.CallbackContext obj)
    {
        _value = obj.ReadValue<Vector2>();
        playerMove.SetDirection(_value);
    }
}