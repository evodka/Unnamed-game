using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 100)
        {
            Destroy(gameObject);
        } 
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("it works!");
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(coll.gameObject);
            Debug.Log("The object was destroyed");
            /*if (coll.gameObject.tag == "Bullet")
            {
                Debug.Log("The object is a bullet");
                Destroy(coll.gameObject);
            }*/
            Debug.Log("I have hit an enemy.");
            Destroy(gameObject);
        }
    }
}
