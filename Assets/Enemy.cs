using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public int ehealth = 3;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
            Destroy(coll.gameObject); //destroying the bullets
        }

        /*#if (coll.gameObject.tag == "Kernel")  #hint for the future different weapon types
        {
            TakeDamage(x);
            Destroy(coll.gameObject); //destroying the bullets
        }*/
    }


    public void TakeDamage (int damage)
    {
        ehealth -= damage;

        if (ehealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        Destroy(gameObject);
    }

}
