using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchHoming : MonoBehaviour
{
    public float speed;
    private Transform play;
    void Start()
    {
        play = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, play.position, speed * Time.deltaTime);
         Destroy(gameObject, 2f);
       
    }
}
