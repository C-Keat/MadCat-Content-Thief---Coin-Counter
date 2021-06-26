using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerGot : MonoBehaviour
{
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Lewis feels somthing");

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Lewis got me");
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }

    }
}


