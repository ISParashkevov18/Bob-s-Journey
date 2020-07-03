using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
	public GameObject[] bottomRooms;
	public GameObject[] topRooms;
	public GameObject[] leftRooms;
	public GameObject[] rightRooms;
	public GameObject ClosedRoom;
	public List<GameObject> rooms;
	public float wait;
	public bool spawnedBoss;
	public GameObject boss;
	
	public GameObject[] enemies;
	// Vector2  v = (1, 0 );
	void Start()
    {
		
}
	void Update()
    {
		if(wait <= 0 && spawnedBoss == false)
        {
			for( int i = 0; i <rooms.Count; i++)
            {
				if(i == rooms.Count -1)
                {
					Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
					spawnedBoss = true;
                }
				else
                {
				 int enemyNumber = Random.Range(1, 4);
	//for( int n = 0; n < 3; n++)
	//  {
	int enemyindex = Random.Range(0, 3);
					if(enemyNumber == 1)
                    {
						Instantiate(enemies[enemyindex], rooms[i].transform.position , Quaternion.identity);
					}
					if(enemyNumber == 2)
                    {
						Instantiate(enemies[enemyindex], rooms[i].transform.position, Quaternion.identity);
						Instantiate(enemies[enemyindex], rooms[i].transform.position + new Vector3(3, 0, 0), Quaternion.identity);
					}
					if(enemyNumber == 3)
                    {
						Instantiate(enemies[enemyindex], rooms[i].transform.position, Quaternion.identity);
						Instantiate(enemies[enemyindex], rooms[i].transform.position + new Vector3(3, 0, 0), Quaternion.identity);
						Instantiate(enemies[enemyindex], rooms[i].transform.position + new Vector3(-3, 0, 0), Quaternion.identity);
					}
						
						//Instantiate(enemies[1], rooms[i].transform.position, Quaternion.identity);
					//}
					
				}
            }
        }
        else
        {
			wait -= Time.deltaTime;
        }

    }
}
