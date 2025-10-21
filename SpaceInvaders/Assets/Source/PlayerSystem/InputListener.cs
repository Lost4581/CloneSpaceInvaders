using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    private InputSystem_Actions m_Actions;
    private bool _canMove = false;
    private Vector2 _value;
    

    private void Start()
    {
        m_Actions = new InputSystem_Actions();
        m_Actions.Player.Move.performed += Move;
        m_Actions.Enable();
        _value = new Vector2();
    }

    private void Update()
    {
        Vector3 velocity = new Vector3(_value.x, 0, 0) * speed * Time.deltaTime;
        gameObject.transform.position += velocity;
        
    }

    private void ActivateBool(InputAction.CallbackContext T)
    {
        _canMove = true;
        Debug.Log(_canMove);
    }

    private void Move(InputAction.CallbackContext obj)
    {
        _value = obj.ReadValue<Vector2>();
        _canMove= true;
        Debug.Log(_canMove);
        Debug.Log(_value);
    }
}
