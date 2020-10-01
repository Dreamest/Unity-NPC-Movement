using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMotion : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent agent;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        controller = GetComponent<CharacterController>();
        agent.updatePosition = false;
        agent.updateRotation = true;
        // agent.SetDestination(target.transform.position);    
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);    

        controller.Move(agent.desiredVelocity.normalized*agent.speed*Time.deltaTime);
        agent.velocity = controller.velocity;
    }
}
