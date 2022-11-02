using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketScript : MonoBehaviour
{
    [SerializeField]
    private float _trustPower = 2;
    private Rigidbody rb;//rocket_rigidbody
    void Start()
    {
        rb = GetComponent<Rigidbody>();//getCompent with start
    }

    
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        //apply thrust
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * _trustPower);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward*Time.deltaTime);
        }
    }
}//class
