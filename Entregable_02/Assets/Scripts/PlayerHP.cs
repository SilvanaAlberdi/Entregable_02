using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    private int playerHP = 100;
    public int damage = 30;
    [SerializeField]
    private bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerHP = playerHP - damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            if (playerHP <= 0)
            {
                Debug.Log("Te has quedad sin vida... GAME OVER");
            }
            else if (playerHP < 20)
            {
                Debug.Log("¡Tienes poca vida!");
            }
            else
            {
                Debug.Log("Vas bien de vida, tienes {playerHP} de puntos de vida");
            }
        }
        if (isGameOver == true)
        {
            Debug.Log("GAME OVER");
        }
    }
}
