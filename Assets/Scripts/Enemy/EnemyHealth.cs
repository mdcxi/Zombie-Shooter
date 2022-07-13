using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    public GameObject desZombie;

   
    bool isDead = false;

    AudioSource gunAudio;

    public bool IsDead() 
    {  
        return isDead; 
    }

    void Awake()
    {
        gunAudio = GetComponent<AudioSource>();
    }

    public void TakeDamage (float damage)
    {
        BroadcastMessage("OnDamageTaken");

        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;

        isDead = true;

        GetComponent<Animator>().SetTrigger("die");
        Destroy(desZombie, 3f);

        gunAudio.Play();
    }
}
