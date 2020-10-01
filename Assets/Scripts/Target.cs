using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 newPos = new Vector3();

        newPos.x = Random.Range(-49f, 42.5f);
        newPos.z = Random.Range(-76f, 67.5f);
        // newPos.y = Terrain.activeTerrain.SampleHeight(newPos);
        Debug.Log("X");
        transform.position = newPos;
        agent.SetDestination(newPos);

    }
}
