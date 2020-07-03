using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LaunchProjectile : MonoBehaviour
{
    public float speed;
    private Transform play;
    private Vector2 target;


    void Start()
    {
        play = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(play.position.x, play.position.y);

    }
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        // Destroy(gameObject, 2f);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProj();
        }
    }


    void DestroyProj()
    {
        Destroy(gameObject);
    }
}
