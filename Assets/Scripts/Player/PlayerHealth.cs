using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    [SerializeField] float maxHealth = 200f;
    public static float health;

    
    public void TakeDamage (float damage)
    {
        maxHealth -= damage;

        if (maxHealth <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
