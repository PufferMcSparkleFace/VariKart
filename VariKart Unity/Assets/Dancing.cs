using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Dancing : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 5;
    public Rigidbody rb1;
    public Rigidbody rb2;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb1.velocity = transform.forward * speed * Time.deltaTime;
        rb2.velocity = transform.forward * speed * Time.deltaTime;
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * rotationSpeed, Space.World);
    }
}
