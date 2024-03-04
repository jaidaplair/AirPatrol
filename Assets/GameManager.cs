using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

//use TMP assests
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreUiText;
    //public int score = 0;
   // public int maxLives = 3;
    //public int currentLives = 3;
    [SerializeField] TMP_Text livesText;
    //[SerializeField] Text gameOverText;
    //[SerializeField] Image gameOver;
   
    //[SerializeField] GameObject gameOverImage;

    public int maxLives = 3;
    public int currentLives = 3;
    public int score = 0;
   //public UnityEvent onRestartGame = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        currentLives = maxLives;
        Update();
        //gameOverImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //converty score to string
        ScoreUiText.text = score.ToString();
        livesText.text = currentLives.ToString();
    }
    /*
    public void LoseLife()
    {
        //currentLives--;
        //Update();
       // if (currentLives <= 0)
        //{
        //    GameOver();
        //}
    }
    /
    public void GameOver()
    {
        gameOverImage.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        onRestartGame.Invoke(); // Invoke the UnityEvent
        Time.timeScale = 1f;
        currentLives = maxLives;
        score = 0;
        Update();
        gameOverImage.SetActive(false);
    }*/
}

