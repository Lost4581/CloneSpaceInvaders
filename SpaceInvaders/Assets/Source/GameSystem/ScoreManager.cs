using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text pointText;
    
    public static ScoreManager Instance;

    private float totalPoints = 0;

    private void Awake() => Instance = this;

    public void AddPoints(float amount)
    {
        totalPoints += amount;
        pointText.text = $"Your point: {totalPoints}";
    }
}