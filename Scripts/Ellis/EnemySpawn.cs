using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Blobby, Duncan, Leo, Lewis, Palp, Shark, Simon, Sips, Toddy
        ,blobbySprite, duncanSprite, leoSprite, LewisSprite, palpSprite, sharkSprite, simonSprite, sipsSprite, toddySprite;
    public int level = 1;
    //public MoveTo moveTo;
    //public bool spawner1, spawner2, spawner3;
    // Start is called before the first frame update
    void Start()
    {
        Toggle(Lewis, 1);
       // MoveTo move = moveTo.GetComponent<MoveTo>();
        Toggle(Lewis, 0);
        // GameObject clone = Instantiate(moveto.gameObject, transform.position, transform.rotation);

        if (level == 1)
        {

            Toggle(Lewis, 1);
            Toggle(LewisSprite, 1);
            //Toggle(Duncan, 1);
            //Toggle(duncanSprite, 1);
            //Toggle(Blobby, 1);
            //Toggle(blobbySprite, 1);

        }
        //move.opener();

    }
    /// <summary>
    /// Switches active state. Pass the element as "Nameofelement".gameObject, and either 0 for false, and 1 for true
    /// </summary>
    public GameObject Toggle(GameObject toggleMe, int id)
    {
        if (id == 1)
        {
            toggleMe.gameObject.SetActive(true);
        }
        if (id == 0)
        {
            toggleMe.gameObject.SetActive(false);
        }

        return toggleMe;

    }
}
