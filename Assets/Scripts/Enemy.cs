using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health = 2;
    [SerializeField] ParticleSystem deathVFX;
    Animator enemyAnimator;

    private void Start()
    {
        enemyAnimator = GetComponentInParent<Animator>();
    }

    private void OnParticleCollision(GameObject other)
    {
        Hit();
    }

    void Hit()
    {
        enemyAnimator.Play("Enemy Hit");
        health--;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        ParticleSystem vfx = Instantiate(deathVFX, transform.position, Quaternion.identity);
        FindObjectOfType<ScoreBoard>().IncreaseScore(30);
        Destroy(gameObject);
        Destroy(vfx.gameObject, 3);
    }

}
