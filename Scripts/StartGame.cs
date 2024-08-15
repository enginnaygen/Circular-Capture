using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI highScoreText;
    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScoreText.text = "highscore: " + PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScoreText.text = "highscore: " + 0;

        }
    }

   
    public void StartGameMethod()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
