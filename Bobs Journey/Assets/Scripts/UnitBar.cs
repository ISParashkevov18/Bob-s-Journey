using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitBar : MonoBehaviour
{
    public Slider test;
    public int maxHealth = 5;
    void Start()
    {
        
        test.maxValue = maxHealth;
        test.value = maxHealth;
    }
 
}
