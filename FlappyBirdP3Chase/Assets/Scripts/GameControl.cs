using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public Text scoreText;
    public TextMeshProUGUI ScoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private int score = 0;
    
    void Awake ()
    {
       if (instance == null)
        {
            instance = this;
        }
       else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            gameOver = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void SonicScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        ScoreText.text = score.ToString();
    }
    public void SonicDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
