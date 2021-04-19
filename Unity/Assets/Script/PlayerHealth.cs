using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //vie max
    public int maxHealth = 100;
    //vie mis a jour
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        //test pour verifier si la barre descend lors d'un dégât
        if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int Damage)
    {
        //Prend des dégâts
        currentHealth -= Damage;
        //Mets a jour la barre de vie
        healthBar.SetHealth(currentHealth);
    }
}
