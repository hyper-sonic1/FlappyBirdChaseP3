using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadnikPool : MonoBehaviour
{
    public int BadnikPoolSize = 5;
    public GameObject BadnikPrefab;
    public float spawnRate = 4f;
    public float BadnikMin = -1f;
    public float BadnikMax = 3.5f;

    private GameObject[] Badniks;
    private Vector2 ObjectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentBadnik = 0;

    // Start is called before the first frame update
    void Start()
    {
        Badniks = new GameObject[BadnikPoolSize];
        for (int i = 0; i < BadnikPoolSize; i++)
        {
            Badniks[i] = (GameObject)Instantiate (BadnikPrefab, ObjectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned = Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range (BadnikMin, BadnikMax);
            Badniks[currentBadnik].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            
        }  
    }
}
