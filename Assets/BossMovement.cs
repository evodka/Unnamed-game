using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float speed = 2.0f;

    void Update(){
        if (GetComponent<Renderer>().isVisible){
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else{
            transform.position += -transform.right * speed * Time.deltaTime;
        }
    }
}
