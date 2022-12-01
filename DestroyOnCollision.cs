using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public AudioClip impactSound;
    public AudioClip quackSound;
    public AudioSource audio;

    public static bool isActive = true;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.CompareTag("Player"))
        {
            GameOver.instance.GameOverFunc();

            audio.PlayOneShot(impactSound, 0.7f);
            audio.PlayOneShot(quackSound, 0.7f);

            collision.gameObject.SetActive(false);
            isActive = false;
        }
    }
}
