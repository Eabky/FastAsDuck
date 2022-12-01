using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public static UI instance;
    public AudioClip coinSound;
    public AudioSource audio;

    public TMP_Text count;
    public TMP_Text finalcount;
    public TMP_Text finalcountend;
    public static int coinCount = 0;

    private void Awake() 
    {
        instance = this;
    }
    void Start()
    {
        count.text = coinCount.ToString();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void IncreaseCoinCount(int v)
    {
        coinCount += v;
        count.text = coinCount.ToString();
        audio.PlayOneShot(coinSound, 0.7f);
    }

    public void TotalAmountOfCoins()
    {
        finalcount.text = coinCount.ToString();
        finalcountend.text = coinCount.ToString();
    }
}
