using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] ParticleSystem deathVFX;
    private void OnParticleCollision(GameObject other)
    {
        ParticleSystem vfx = Instantiate(deathVFX, transform.position, Quaternion.identity);
        FindObjectOfType<ScoreBoard>().IncreaseScore(30);
        Destroy(gameObject);
        Destroy(vfx, 3);
    }
}
