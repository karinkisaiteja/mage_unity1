using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthsystem : MonoBehaviour
{
    public int maxHealth = 25;
    public int currentHealth;
    public healthbar HealthBar;
    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.SetMaxhealth(maxHealth);
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collosion");
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (other.gameObject.tag == "damageobject")
        {
            DamagePlayer(5);
        }
    }


    public void DamagePlayer(int damage)
    {
        currentHealth -= damage;

        HealthBar.SetHealth(currentHealth);
    }
}