using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public TextMeshProUGUI ScoreText;
    public bool gameOver = false;
    
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void SonicDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
