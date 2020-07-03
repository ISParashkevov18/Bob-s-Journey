using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DetectPlayerHits : MonoBehaviour
{
    public int maxHealth = 5;
    public int current;
     public Slider test;
    
    void Start()
    {
         test = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
      
        current = maxHealth;
     
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("boss"))
        {
           
            Debug.Log("MeleeEnemy is hit");
            test.value = test.value - 1;
            if (test.value == 0)
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
      
       
    }
    void Update()
    {
       
    }
     public void SetMaxHealth(int health)
    {
        test.maxValue = health;
        test.value = health;
    }
    public void SetHealth(int health)
    {
       test.value = health;
    }
}
