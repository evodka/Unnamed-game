using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet : MonoBehaviour
{
    //public GameObject hitEffect;

    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }


    /*void OnCollisionEnter2D(Collision2D coll)
    {
        Instantiate(hitEffect, transform.position, transform.rotation);
    }*/


    void OnBecameInvisible() //when bullets are out of camera view, destroy them
    {
        Destroy(gameObject);
    }
}
