using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using  UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent agent;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = player.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(0);
    }
}
