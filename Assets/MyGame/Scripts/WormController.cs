﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class WormController : MonoBehaviour
{

    public GameObject bazooka;
    public GameObject canon;
    public Transform canonPosition;
    public float shoot = 75;
    public Rigidbody rb;
    public Vector3 jump;
    public Vector3 move;

    public Text healthDisplay;
   
   
    public int health = 10;

void Start() {
        
            
            healthDisplay.text = health.ToString();
            
        
        }

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

            if (Input.GetKey(KeyCode.Q))
            {
                Debug.Log("Q is to rotate left");
                bazooka.transform.Rotate(0, 0, -5, Space.Self);
            }

        
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("E is to rotate right");
                bazooka.transform.Rotate(0, 0, 5, Space.Self);
            }

    }

        
        
        
        
    

        void OnCollisionEnter(Collision collision) {

            if(collision.gameObject.tag == "DamageZone")
            {

            Debug.Log("You hit the DamageZone");
            health = health - 2;
            healthDisplay.text = health.ToString();

            } 
            else 
            {
            Debug.Log("You hit something besides the DamageZone");
            }

           if(collision.gameObject.tag == "HealthPackage")
           {

            Debug.Log("You got a Health Package!");
            health = health + 1;
            Destroy(collision.gameObject);
            healthDisplay.text = health.ToString();
           }
           
        
    }

}


