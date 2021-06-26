using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perception : MonoBehaviour
{
   public OGMoveTo moveto;
    public GameObject Player;
    public Transform lastPos;
    
    private void Start()
    {
        OGMoveTo oGMoveTo = moveto.GetComponent<OGMoveTo>();
        //Physics2D.IgnoreCollision(!Player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("I can ssee the playuer");
            moveto.goal.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
            lastPos.position = moveto.goal.position;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("test");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("I can ssee the playuer");
            moveto.goal.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
            lastPos.position = moveto.goal.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        moveto.goal.position = lastPos.position;
        Debug.Log("i have lost the player");
    }
}

    