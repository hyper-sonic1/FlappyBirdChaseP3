using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badniks : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<SonicJump>() != null)
        {
            GameControl.instance.SonicScored ();
            
        }
    }
}
