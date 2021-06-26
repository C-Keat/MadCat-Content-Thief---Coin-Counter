using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ainav : MonoBehaviour
{
    public MoveTo moveTo;
    public NavMeshAgent nma;
    public bool called, ready = false;
    public Transform goal;
    private void Start()
    {
        MoveTo moveToo = moveTo.GetComponent<MoveTo>();
    }

    void FixedUpdate()
    {
        if (ready == true)
        {
            if (Mathf.Approximately(this.transform.position.x, moveTo.goal.position.x) && Mathf.Approximately(this.transform.position.y, goal.position.y) && called == false)
            {
                called = true;
                StartCoroutine(waitAtLocation());
                Debug.Log("Called transforms are same");

            }

            nma.destination = goal.position;
            //will walk toward the goal
            //this.goal.position = new Vector3(goal.position.x, goal.position.y, 0);
            //foreach (NavMeshAgent a in agents)
            //{
            //    a.GetComponent<NavMeshAgent>();
            // a.destination = goal.position;
            //}
        }
    }

    public IEnumerator waitAtLocation()
    {
        Debug.Log("Started");
        yield return new WaitForSeconds(7);

        moveTo.newLocation();
        Debug.Log("Ended");
        called = false;
    }
}
