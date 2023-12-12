using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl Instance;
    public GameObject gameOverText;
    public TextMeshProUGUI ScoreText;
    public bool gameOver = false;
    
    void Awake ()
    {
       if (Instance == null)
        {
            Instance = this;
        }
       else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    
    void Update()
    {
        
    }

    public void SonicDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
