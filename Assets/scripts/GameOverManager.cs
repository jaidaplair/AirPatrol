
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;

    //[SerializeField] Text score;

    public void SetGameOver()
    {
        GameManager gm;
        gm = FindAnyObjectByType<GameManager>();
        gameOverScreen.SetActive(true);
        // Time.timeScale = 0f;

        Time.timeScale = 0;

    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        //Time.timeScale = 1f;
    }
}
