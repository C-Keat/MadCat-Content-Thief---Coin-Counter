using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class checkcollision : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("collided with " + collision.name);
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Lewis got me");
            SceneManager.LoadScene("Yogtowers");
        }

    }
}
