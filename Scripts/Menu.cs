using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void playGame2()
    {
        SceneManager.LoadScene(2);
    }
    public void leaveGame()
    {
        Application.Quit();
        Debug.Log("quitting");
    }
    public void credits()
    {
        SceneManager.LoadScene(3);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
