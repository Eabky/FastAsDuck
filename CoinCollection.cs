using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public int value;

    private void OnTriggerEnter(Collider collider) 
    {

        if(collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Coin Collected");
            Destroy(gameObject);
            UI.instance.IncreaseCoinCount(value);
        }
    }
}
