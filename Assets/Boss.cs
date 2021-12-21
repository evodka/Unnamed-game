using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
        public int bhealth = 10;

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
        bhealth -= damage;

        if (bhealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        Destroy(gameObject);
    }

}
