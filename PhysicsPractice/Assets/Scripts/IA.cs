using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class IA : MonoBehaviour
{
    NavMeshAgent Agent;
    public Transform target;
    public float distancia_ataque;
    public bool atacando;
    Animator animator;

    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(target.position);
        if(Vector3.Distance(transform.position, target.transform.position) > distancia_ataque)
        {
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }
    }
}
