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
    public float score;
    public float deadScore;
    public GameObject DeadScene;
    public GameObject Message;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        deadScore = 0;
        DeadScene.SetActive(false);
        Message.SetActive(true);
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpingFre;
            Time.timeScale = 1;
            Message.SetActive(false);
        }

        scoreText.text = score.ToString();
        deadScoreText.text = score.ToString();


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
        }
        if (temas.gameObject.tag == "Place")
        {
            SoundManager.instance.skyscraperSource.PlayOneShot(SoundManager.instance.CrashSound);
            Time.timeScale = 0;
             DeadScene.SetActive(true);
        }
    }
}
