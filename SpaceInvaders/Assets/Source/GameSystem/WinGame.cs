using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;

    public void CheckForVictory()
    {
        if (winPanel == null) return;

        GameObject[] enemiesLeft = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemiesLeft.Length == 0)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}