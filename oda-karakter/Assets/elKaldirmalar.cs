using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elKaldirmalar : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Animator bileşenini bulup referans ataması yapıyoruz
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetTrigger("hizliEl");
            animator.SetTrigger("SitDown");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetTrigger("yavasEl");
            animator.SetTrigger("SitDown");
        }
    }
}
