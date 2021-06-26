using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerPickUp : MonoBehaviour
{
    public CoinCounter counterOfCoins;
    public HUD Hud;
    // public float startingTime;
    //float currentTime;
    // [SerializeField]Text countdownText;
    int coinsCollected = 0, coinsToWin = 3;
    bool endGame = false;


    private void Start()
    {
        CoinCounter count = counterOfCoins.GetComponent<CoinCounter>();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
          
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
              
                    Debug.Log("Item picked up");
                    Hud.CloseMessagePanel();
                    counterOfCoins.getCoin();
                    gameObject.SetActive(false);
                   
                    Hud.CloseMessagePanel();
                  
            }                
                               
        }
       else
        {
          Debug.Log("didnt call nothing");
         
        }
     
     
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Hud.OpenMessagePanel("");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Hud.CloseMessagePanel();

        //currentTime = startingTime;
    }

}

