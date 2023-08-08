using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject Top;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.SetDestination(Top.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "top")
        {
            SceneManager.LoadScene("Scenes/Sahne2");
        }
    }
}