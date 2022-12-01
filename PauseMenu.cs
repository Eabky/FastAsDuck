using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    private AudioSource[] audioSources;

    void Start() 
    {
        pauseMenu.SetActive(false);

        var temp = GameObject.FindGameObjectsWithTag("Audio");
        audioSources = new AudioSource[temp.Length];

        for (int i = 0; i < audioSources.Length; i++) 
        {
            audioSources[i] = temp[i].GetComponentInChildren<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        foreach (var audioSource in audioSources) 
        {
            audioSource.Stop();
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        foreach (var audioSource in audioSources) 
        {
            audioSource.Play();
        }
    }

    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
