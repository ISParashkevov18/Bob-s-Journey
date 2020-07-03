using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float line;
    public float range;
    private Transform play;
    public float TimeBetweenShots;
        public float startTime;
    public GameObject bullet;
    public GameObject Parent;
    void Start()
    {
        play = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
     
        float distance = Vector2.Distance(play.position, transform.position);
        if(distance < line && distance > range)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, play.position, speed * Time.deltaTime);
        }
        else if( distance <= range)
        {
            if (TimeBetweenShots <= 0)
            {
                Instantiate(bullet, Parent.transform.position, Quaternion.identity);
                TimeBetweenShots = startTime;
            }
            else
            {
                TimeBetweenShots -= Time.deltaTime;
            }

        }
    }
    }