using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Dancing : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb1, rb2;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);

    }

    public void OnCollisionEnter(Collision collision)
    {
        speed = 0;
        rb1.useGravity = true;
        rb2.useGravity = true;
    }
}
