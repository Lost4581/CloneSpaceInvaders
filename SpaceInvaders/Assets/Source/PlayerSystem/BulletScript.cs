using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rb.linearVelocity = transform.up * speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}