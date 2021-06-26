using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAssigner : MonoBehaviour
{
    MoveTo moveTo;
    AIfollownavmesh aIfollownavmesh;
    public GameObject[] enimiesArray;
    int i ;
    private void Start()
    {
        MoveTo moveToScript = moveTo.GetComponent<MoveTo>();
        AIfollownavmesh aIfollownavmeshscript = aIfollownavmesh.GetComponent<AIfollownavmesh>();

        enimiesArray = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject o in enimiesArray)
        {
            
             i = Random.Range(0, 8);
        }
    }
}
