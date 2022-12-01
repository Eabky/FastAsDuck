using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
    public static TheEnd instance;
    public GameObject theEnd;
    private AudioSource[] audioSources;
    

    public static bool gameHasEnded = false;

    private void Awake() 
    {
        instance = this;
    }

    void Start()
    {
        theEnd.SetActive(false);

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

    public void TheEndFunc()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;

            theEnd.SetActive(true);
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

