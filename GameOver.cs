using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static GameOver instance;
    public GameObject gameOver;
    private AudioSource[] audioSources;
    

    public static bool gameHasEnded = false;

    private void Awake() 
    {
        instance = this;
    }

    void Start()
    {
        gameOver.SetActive(false);

        var temp = GameObject.FindGameObjectsWithTag("Audio");
        audioSources = new AudioSource[temp.Length];

        for (int i = 0; i < audioSources.Length; i++) 
        {
            audioSources[i] = temp[i].GetComponentInChildren<AudioSource>();
        }
    }

    void Update()
    {
        
    }

    public void GameOverFunc()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;

            gameOver.SetActive(true);
            Time.timeScale = 0f;

            foreach (var audioSource in audioSources) 
            {
                audioSource.Stop();
            }

            UI.instance.TotalAmountOfCoins();
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
