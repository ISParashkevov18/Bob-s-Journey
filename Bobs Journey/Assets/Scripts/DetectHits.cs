using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHits : MonoBehaviour
{
    private int hits = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerProj"))
        {
            hits++;
           
        }

        if(hits == 3)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
