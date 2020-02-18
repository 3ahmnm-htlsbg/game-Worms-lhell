using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WormController : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 jump;
    public Vector3 move;

    void Update()
        {
        if (Input.GetKeyDown(KeyCode.W)) 
            {
            Debug.Log("W is to jump");
            rb.AddForce(jump);
            }

           if (Input.GetKeyDown(KeyCode.A))
            {
            Debug.Log("A is to move to the left");
            rb.AddForce(-move);
        }

            if (Input.GetKeyDown(KeyCode.D)){
            Debug.Log("D is to move to the right");
            rb.AddForce(move);
        } 

            if (Input.GetKeyDown(KeyCode.C))
            {
            Debug.Log("C is to shoot");
            }

    }
}


