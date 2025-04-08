using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject[] targets;

    void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("Player");
        if (targets.Length == 0) return;

        GameObject target = null;

        float minDistance = Mathf.Infinity;
        foreach(var t in targets)
        {
            var distance = Vector3.Distance(t.transform.position, transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                target = t;
            }
        }
        if (target != null)
            agent.SetDestination(target.transform.position);
    }
}
