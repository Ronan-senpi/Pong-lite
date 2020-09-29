using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public class NavMeshTargetScript : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private NavMeshAgent agent;
    private bool isStop = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        agent.SetDestination(target.transform.position);
        if (agent.remainingDistance != Mathf.Infinity && agent.remainingDistance <= agent.stoppingDistance && !isStop)
        {
            this.isStop = true;
            StartCoroutine(BlowUp());
        }
    }

    IEnumerator BlowUp()
    {
        yield return new WaitForSeconds(1.5f);
        Debug.LogError("BOOOOM !");
        Destroy(gameObject);
    }

}
