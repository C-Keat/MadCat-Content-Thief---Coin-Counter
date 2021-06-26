using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CoinCounter : MonoBehaviour
{
    public int currentCoins = 0, coinsToWin = 2;

    public void getCoin()
    {
        currentCoins = currentCoins + 1;

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentCoins == coinsToWin)
        {
            //load the final scene page
            SceneManager.LoadScene(4);
        }
    }
}

