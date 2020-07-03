using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MeleeEnemy : MonoBehaviour
{
    public float speed;
    public float line;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
       
    }
    
    void Update()
    {
        float distance = Vector2.Distance(player.position, transform.position);
        if(distance < line)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, line);
    }
}
