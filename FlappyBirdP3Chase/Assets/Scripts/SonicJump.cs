using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicJump : MonoBehaviour {

    public float upforce = 200f;

    private bool isDead = false;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upforce));
        }

    }

    void OnCollisionEnter2D()
    {
        
    }
}
