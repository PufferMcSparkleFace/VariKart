using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapGamemode : MonoBehaviour
{
    public float start = 0;
    public float end = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(start == 4 && end == 3)
        {
            Debug.Log("Finished");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if(other.tag == "start")
        {
            start += 1;
        }
        if(other.tag == "end")
        {
            end += 1;
        }
    }
}
