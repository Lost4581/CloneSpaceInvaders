using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 7;

    private Vector2 currentValue;

    public void SetDirection(Vector2 _value) => currentValue = _value;

    void Update()
    {
        MovePerson();
    }

    private void MovePerson()
    {
        Vector3 velocity = new Vector3(currentValue.x, 0, 0) * speed * Time.deltaTime;
        gameObject.transform.position += velocity;
    }
}