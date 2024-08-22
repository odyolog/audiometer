using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SitTrigger : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        print("Karakter kutuya yaklaştı.");
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Eğer karakter tag'li bir kutuya girerse
        if (other.CompareTag("SittingArea"))
        {
            print("Karakter kutuya yaklaştı.");
            animator.SetTrigger("SitDown");

            // Pozisyonu güncelle
            transform.position = new Vector3(62.3f, 6.1f, -47.2f);

            // Rotasyonu güncelle
            transform.rotation = Quaternion.Euler(0, -84.503f, 0);
        }
   
    }

 
}

