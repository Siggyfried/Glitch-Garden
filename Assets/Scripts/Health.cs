using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float health = 100f;
    [SerializeField] private GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    public void TriggerDeathVFX()
    {
        if (!deathVFX)
        {
            return;
        }
        GameObject DeathVFXObject = Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(DeathVFXObject, 1f);
    }
}
