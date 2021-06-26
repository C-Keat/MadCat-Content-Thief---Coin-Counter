using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
 
     
    public Transform target;//set target from inspector instead of looking in Update
    Quaternion enemyRotation;
    Vector2 playerPos, enemyPos;


    //protected override void Start()
    //{
    //    base.Start();
    //   // enemyRotation = this.transform.localRotation;
    //}

    void Update()
    {
        

        playerPos = new Vector2(target.localPosition.x, target.localPosition.y);//player position 
        enemyPos = new Vector2(this.transform.localPosition.x, this.transform.localPosition.y);//enemy position
        if (Vector3.Distance(transform.transform.position, target.transform.position) > 1.6)//move towards if not close by 
        {
            transform.position = Vector2.MoveTowards(enemyPos, playerPos, 2 * Time.deltaTime);
        }
        if (Vector3.Distance(transform.transform.position, target.transform.position) < 1.55)//move away if too close 
        {
            transform.position = Vector2.MoveTowards(enemyPos, playerPos, -1 * Time.deltaTime);
        }

        //if (target.position.x > transform.position.x)//rotates enemy to the right if player is to the right  
        //{
        //    enemyRotation.x = 180;
        //    transform.localRotation = enemyRotation;
        //}
        //if (target.position.x < transform.position.x)//rotates enemy to the left if player is to the left 
        //{
        //    enemyRotation.x = 0;
        //    transform.localRotation = enemyRotation;
        //}
    }
}
