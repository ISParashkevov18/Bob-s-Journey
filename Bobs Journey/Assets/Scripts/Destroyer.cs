using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Closed"))
        {
            Destroy(other.gameObject);
        }
    }
}
