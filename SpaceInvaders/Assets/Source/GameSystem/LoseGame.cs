using UnityEngine;

public class LoseGame : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            Time.timeScale = 0f;
            losePanel.SetActive(true);
        }
    }
}
