using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    
    private Transform play;
    void Start()
    {
        play = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        Vector2 position = transform.position;
        position.x += xSpeed;
        position.y += ySpeed;
        transform.position = position;

        if (transform.position.x > play.position.x + 5 || transform.position.x < play.position.x - 5  || transform.position.y < play.position.y - 5 || transform.position.y > play.position.y + 5)
        {
           Destroy(gameObject);
       }
    }
}
