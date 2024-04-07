using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballsounds : MonoBehaviour
{
    public AudioSource collideSound;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // basically the magnitude of the collosion controls how loud the sound should be
        float collideSpeed = Mathf.Clamp(collision.relativeVelocity.magnitude/30f, 0f, 1f);
        if (collideSpeed > 0.3)
        {
            collideSound.PlayOneShot(collideSound.clip, collideSpeed);
        }
    }
}
