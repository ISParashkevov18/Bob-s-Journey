using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class test : MonoBehaviour
{
    public int maxHealth = 10;
    public int current;
    public HealthBar healthBar;
    void Start()
    {

        current = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Proj"))
        {
            current -=1;
            Debug.Log("hit");
            healthBar.SetHealth(current);
            Destroy(other.gameObject);

        }
        if(other.CompareTag("MeleeEnemy"))
        {
            current -= 1;
            Debug.Log("MeleeHit");
            healthBar.SetHealth(current);
        }
        if (other.CompareTag("boss"))
        {
            current -= 1;
            Debug.Log("MeleeHit");
            healthBar.SetHealth(current);
        }
        if (current == 0)
        {
            Debug.Log("Reload");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
