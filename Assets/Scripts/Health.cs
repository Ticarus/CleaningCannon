using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 10;
    [SerializeField] ParticleSystem hitEffect;

    Enemy enemy;
    ScoreKeeper scoreKeeper;
    LevelManager levelManager;

    void Awake()
    {
        enemy = FindObjectOfType<Enemy>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        DamageDealer damageDealer = collision.GetComponent<DamageDealer>();
        if(damageDealer != null && gameObject.tag == "Dirty")
        {
            TakeDamage(damageDealer.GetDamage());
            PlayHitEffect();
            damageDealer.Hit();
        }
    }

    public int GetHealth()
    {
        return health;
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            enemy.SetSprite(enemy.GetCleanSprite());
            gameObject.tag = "Clean";
            scoreKeeper.ModifyScore(enemy.GetScoreValue());
        }
    }

    void PlayHitEffect()
    {
        if(hitEffect != null)
        {
            ParticleSystem instance = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(instance.gameObject, instance.main.duration + instance.main.startLifetime.constantMax);
        }
    }
}
