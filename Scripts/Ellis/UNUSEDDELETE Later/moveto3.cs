using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class moveTo3 : MonoBehaviour
{
    public Transform goal, streamRoom, streamSetup, mensToilets, womensToilets, lift1, lift2, kitchenCounter, kitchenLocker,
        officeShelfs, mainOffice1, mainOffice2, mainOffice3, jinglejam, vrRoom, storage, editingRoom, office1, office2, office3, office4
        , office5, office6, hatRoom, pokerRoom;

    private bool patrolRoute1, patrolRoute2, patrolRoute3; public bool called;
    //, blobbySprite, duncanSprite, LeoSprite, lewisSprite, palpSprite, sharkSprite, simonSprite, sipsSprite, toddySprite;
    private int i, lastLocation = 0;

    //public List<NavMeshAgent> agents = new List<NavMeshAgent>();


    //only tick one patrol route and one sprite in inspector!

    [SerializeField]
    NavMeshAgent agent; //reference to an object with NavMeshAgent agent, set it in inspector, for example

    void Start()
    {
        //Debug.Log("THIS particular script is on " + gameObject.name);
        //foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Enemy"))
        //{
        //    agents.Add(obj.GetComponent<NavMeshAgent>());

        //}

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //if (gameObject.name == "Lewis" || gameObject.name == "Toddy" || gameObject.name == "Simon")
        //{
        //    patrolRoute1 = true;
        //    Debug.Log("pat1 is true");
        //}
        //if (gameObject.name == "Duncan" || gameObject.name == "LeoAzure" || gameObject.name == "Sips")
        //{
        //    patrolRoute2 = true;
        //    Debug.Log("pat2 is true");
        //}
        //if (gameObject.name == "Blobby" || gameObject.name == "Palp" || gameObject.name == "Shark")
        //{
        //    patrolRoute3 = true;
        //    Debug.Log("pat3 is true");
        //}
        //foreach (NavMeshAgent nma in agents)
        //{

        newLocation();
        // }
        // i = Random.Range(0, 8);
        //if(i == 0) { patrolRoute1 = true; }
        //if (i == 1) { patrolRoute2 = true; }
        //if (i == 2) { patrolRoute3 = true; }
        //Debug.Log("Number chosen: " + i + " patrol route1 " + patrolRoute1 + " patrol route 2 " + patrolRoute2 + "patrol route 3 " + patrolRoute3);
    }
    //tags for different location groups and patrol locations
    //locations groups random selection, wait at locations

    void FixedUpdate()
    {

        if (Mathf.Approximately(this.transform.position.x, goal.position.x) && Mathf.Approximately(this.transform.position.y, goal.position.y) && called == false)
        {
            called = true;
            StartCoroutine(waitAtLocation());
            Debug.Log("Called transforms are same");

        }

        agent.destination = goal.position;
        //will walk toward the goal
        //this.goal.position = new Vector3(goal.position.x, goal.position.y, 0);
        //foreach (NavMeshAgent a in agents)
        //{
        //    a.GetComponent<NavMeshAgent>();
        // a.destination = goal.position;
        //}

    }

    public IEnumerator waitAtLocation()
    {
        Debug.Log("Started");
        yield return new WaitForSeconds(7);

        newLocation();
        Debug.Log("Ended");
    }

    void newLocation()
    {

        i = Random.Range(0, 5);
        if (lastLocation == i)
        {
            i++;
            if (i >= 6)
            {
                i = 0;
            }
        }
        #region patrolRoute1
        if (patrolRoute1 == true)//lewis, toddy, simon
        {
            Debug.Log("pat1");
            if (i == 0)//streamroom
            {
                goal.position = streamRoom.transform.position;
            }
            if (i == 1)//streamsetup
            {
                goal.position = streamSetup.transform.position;
            }
            if (i == 2)//mens toilets
            {
                goal.position = mensToilets.transform.position;
            }
            if (i == 3)//kitchen
            {
                goal.position = kitchenCounter.transform.position;
            }
            if (i == 4)//storage
            {
                goal.position = storage.transform.position;
            }
            if (i == 5)//office3
            {
                goal.position = office3.transform.position;
            }
            Debug.Log("Goal position " + i);

        }
        #endregion

        #region patrolRoute2
        if (this.patrolRoute2 == true) //duncan, leo, sips
        {
            Debug.Log("pat2");
            if (i == 0)//office5
            {
                goal.position = office5.transform.position;
            }
            if (i == 1)//pokerRoom
            {
                goal.position = pokerRoom.transform.position;
            }
            if (i == 2)//kitchen
            {
                goal.position = kitchenLocker.transform.position;
            }
            if (i == 3)//mainOffice3
            {
                goal.position = mainOffice3.transform.position;
            }
            if (i == 4)//jinglejam
            {
                goal.position = jinglejam.transform.position;
            }
            if (i == 5)//vroom
            {
                goal.position = vrRoom.transform.position;
            }
            Debug.Log("Goal position " + i);
        }
        #endregion

        #region patrolroute 3
        if (this.patrolRoute3 == true)//blobby, palp, shark
        {
            Debug.Log("pat3");
            if (i == 0)//editroom
            {
                goal.position = editingRoom.transform.position;
            }
            if (i == 1)//hatroom
            {
                goal.position = hatRoom.transform.position;
            }
            if (i == 2)//jinglejam
                goal.position = jinglejam.transform.position;

            if (i == 3)//kitchen
            {
                goal.position = kitchenCounter.transform.position;
            }
            if (i == 4)//shelfs
            {
                goal.position = officeShelfs.transform.position;
            }
            if (i == 5)//mainoffice1
            {
                goal.position = mainOffice1.transform.position;
            }
            Debug.Log("Goal position " + i);
        }

        #endregion
        called = false;
    }
}

