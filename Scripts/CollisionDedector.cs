using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDedector : MonoBehaviour
{
    int score;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] AudioClip clickSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
        scoreText.text = score.ToString();
        FindObjectOfType<ParticleSystem>().Play();
        FindObjectOfType<Animation>().Play();
        AudioSource.PlayClipAtPoint(clickSound,Camera.main.transform.position);

        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);

        }
    }
}
