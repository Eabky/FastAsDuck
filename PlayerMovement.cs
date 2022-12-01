using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerPush;
    [SerializeField] float playerSpeed;
    private float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        UI.coinCount = 0;
        GameOver.gameHasEnded = false;
        TheEnd.gameHasEnded = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * playerPush);
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);
    }
}
