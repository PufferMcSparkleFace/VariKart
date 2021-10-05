using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoosts : MonoBehaviour
{
    public Rigidbody Rigidbody;
    

    // Start is called before the first frame update
    void Start()
    {
        float speed = Rigidbody.velocity.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
