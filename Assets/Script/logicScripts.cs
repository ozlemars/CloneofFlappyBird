using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScripts : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text HighScoreText;
    public GameObject GameOverScreen;
    public AudioSource point;
    private int savedHighScore;
    void Start()
    {
        // Load the saved high score on game start
        savedHighScore = PlayerPrefs.GetInt("HighScore", 0);
        HighScoreText.text = "High Score: " + savedHighScore.ToString();
    }

    public void addScore( int scoreToAdd)
    {
        playerScore = playerScore+ scoreToAdd; //playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
        point.Play();

        //Yeni skorun en yüksek skor olup olmadýðýný kontrol et
        if (playerScore > savedHighScore)
        {
            savedHighScore = playerScore;
            HighScoreText.text = "High Score: " + savedHighScore.ToString();

            //Yeni en yüksek puaný kalýcý olarak kaydet
            PlayerPrefs.SetInt("HighScore", savedHighScore);
        }

    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
       GameOverScreen.SetActive(true);
    }
}
