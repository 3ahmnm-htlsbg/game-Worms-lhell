using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WormController : MonoBehaviour
{

    public GameObject bazooka;
    public GameObject canon;
    public Transform canonPosition;
    public float shoot = 75;
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

            if (Input.GetKeyDown(KeyCode.D))
            {
            Debug.Log("D is to move to the right");
            rb.AddForce(move);
            } 

            if (Input.GetKeyDown(KeyCode.C))
            {
             Debug.Log("C is to shoot");
             GameObject sphere = Instantiate(canon, canonPosition.position, Quaternion.identity);
             sphere.GetComponent<Rigidbody>().AddForce(canon.transform.up * shoot);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Q is to rotate left");
                canon.transform.Rotate(0, 0, -5, Space.Self);
            }

        
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E is to rotate right");
                canon.transform.Rotate(0, 0, 5, Space.Self);
            }

    }
}


