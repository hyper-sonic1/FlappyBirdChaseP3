using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicJump : MonoBehaviour {

    public float upforce = 200f;

    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;

    AudioSource audioSource;
    public AudioClip SonicDeath;
    public AudioClip Checkpoint;
    public AudioClip Sonicjump;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upforce));
                anim.SetTrigger("Jump");
               
            }
        }
        if(Input.GetMouseButtonDown(0)) 
        { 
           Sonicjump = GetComponent<AudioClip>();
        }
    }

    void OnCollisionEnter2D()
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger ("Die");
        GameControl.instance.SonicDied();
        
    }

}
