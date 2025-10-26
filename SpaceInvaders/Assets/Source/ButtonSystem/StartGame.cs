using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0f;
    }

    public void TimeScaleTrue()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
}
