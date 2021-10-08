using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapGamemode : MonoBehaviour
{
    public float start = 0;
    public float end = 0;
    public bool cantrigger = true;
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
        if(other.tag == "Start" && cantrigger == true)
        {
            start += 1;
            cantrigger = false;
        }
        if(other.tag == "End" && cantrigger == true)
        {
            end += 1;
            cantrigger = false;
        }
        if(other.tag == "Checkpoint")
        {
            cantrigger = true;
        }
    }
}
