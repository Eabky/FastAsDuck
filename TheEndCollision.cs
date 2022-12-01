using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEndCollision : MonoBehaviour
{
    public static bool isActive = true;
    
    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.CompareTag("Player"))
        {
            TheEnd.instance.TheEndFunc();

            collision.gameObject.SetActive(false);
            isActive = false;
        }
    }
}
