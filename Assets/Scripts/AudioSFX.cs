using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gameOverClip;
    [SerializeField] private AudioClip magicMissileLaunchClip;
    [SerializeField] private AudioClip takeDamageClip;

    public void PlayGameOver()
    {
        audioSource.PlayOneShot(gameOverClip);
    }

    public void playMagicMissileLaunch()
    {
        audioSource.PlayOneShot(magicMissileLaunchClip);
    }
        public void PlayTakeDamage()
    {
        audioSource.PlayOneShot(takeDamageClip);
    }
}
