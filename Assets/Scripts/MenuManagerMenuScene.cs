using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManagerMenuScene : MonoBehaviour
{
    public TMP_Text HighScore;

    public void StartButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    public void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
