using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScripts : MonoBehaviour
{

    public float jumpingFre;
    Rigidbody2D rb;
    public Text scoreText;
    public Text deadScoreText;
    public int score;
    public float deadScore;
    public GameObject DeadScene;
    public GameObject Message;
    public GameObject HighScoreText;
    public GameObject HighScore;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        deadScore = 0;
        DeadScene.SetActive(false);
        Message.SetActive(true);
        HighScoreText.SetActive(true);
        HighScore.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpingFre;
            Time.timeScale = 1;
            Message.SetActive(false);
            HighScoreText.SetActive(false);
            HighScore.SetActive(false);
        }

        scoreText.text = score.ToString();
        deadScoreText.text = score.ToString();

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Scorer")
        {
            score++;
            deadScore++;
        }
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Skyscraper")
        {
            SoundManager.instance.skyscraperSource.PlayOneShot(SoundManager.instance.CrashSound);
            Time.timeScale = 0;
            DeadScene.SetActive(true);
            Destroy(gameObject);
        }
        if (temas.gameObject.tag == "Place")
        {
            SoundManager.instance.skyscraperSource.PlayOneShot(SoundManager.instance.CrashSound);
            Time.timeScale = 0;
             DeadScene.SetActive(true);
            Destroy(gameObject);
        }
    }
}
