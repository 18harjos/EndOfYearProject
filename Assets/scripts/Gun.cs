﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public bool test = true;
    Animator anim;

    public Camera fpsCam;
    

    // Update is called once per frame

    void Awake()//Enabling the animation for the game
    {
        anim = GetComponent<Animator>();
    }

    void Update() //If the 
    {
        

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            anim.Play("Fire", 0, 0);
            
                
            
        }

        
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
