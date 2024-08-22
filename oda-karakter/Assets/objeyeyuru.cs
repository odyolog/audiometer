using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovement : MonoBehaviour
{
    public Transform target;  // Hedef nokta

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // NavMeshAgent bileşenini al
        agent.SetDestination(target.position);  // Karakteri hedefe doğru hareket ettir
    }

    void Update()
    {
        // İsterseniz burada ek kontroller ekleyebilirsiniz, örneğin hedefe ulaşıldığında bir şeyler yapmasını sağlamak gibi.
    }
}

