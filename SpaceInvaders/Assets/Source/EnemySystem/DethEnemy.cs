using UnityEngine;
using TMPro;

public class DethEnemy : MonoBehaviour
{
    [SerializeField] private WinGame winGame;
    [SerializeField] private TMP_Text pointText;
    [SerializeField] private float howManyAddPoint = 1f;

    public float _howManyPoint = 0f;

    private void Start()
    {
        pointText.text = $"Your point: {_howManyPoint}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            ScoreManager.Instance?.AddPoints(howManyAddPoint);
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        winGame.CheckForVictory();
    }
}