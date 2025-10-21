using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    private InputSystem_Actions m_Actions;
    [SerializeField] private float speed = 1;

    void Start()
    {
        m_Actions = new InputSystem_Actions();
        m_Actions.Player.Move.performed += Move;
        m_Actions.Enable();
    }

    private void Move(InputAction.CallbackContext obj)
    {
        var value = obj.ReadValue<Vector2>();
        var velocity = new Vector3(value.x, value.y, 0) * speed * Time.deltaTime;
        gameObject.transform.position += velocity;
        Debug.Log(value);
    }
}
