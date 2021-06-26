using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIfollownavmesh : MonoBehaviour
{
    //public Rigidbody2D rb;
    public GameObject follow;
    //public bool blobbySprite, duncanSprite, LeoSprite, lewisSprite, palpSprite, sharkSprite, simonSprite, sipsSprite, toddySprite;
    int correctSprite = 0;
    private void Start()
    {
         MoveTo mmoveTo = follow.GetComponent<MoveTo>();
        //this.transform.position = new Vector3(0, 0, -100);
        
        
        
    }
   
    void Update()
    {

        this.transform.position = new Vector3(follow.transform.position.x, follow.transform.position.y, this.transform.position.z);
        
        
        
    }
}
