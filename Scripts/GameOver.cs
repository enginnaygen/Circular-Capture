using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TextMeshProUGUI scoreText, gameOverScoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOverPanel.SetActive(true);
        gameOverScoreText.text = "score:" + scoreText.text;
        collision.gameObject.SetActive(false);
    }

    public void ReStartGame()
    {
        SceneManager.LoadScene(1);
    }  
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
