using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float totalTime = 7f;
    [SerializeField] private float enemyStep = 0.5f;

    private float currentTime;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        Timer();
    }

    private void Timer()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            currentTime = totalTime;
            EnemyMove();
        }
    }

    private void EnemyMove()
    {
        Vector3 stepValue = new Vector3(0, enemyStep, 0);
        gameObject.transform.position -= stepValue;
    }
}