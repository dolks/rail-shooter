using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    [SerializeField] ParticleSystem explosionVFX;

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        //GetComponent<PlayerController>().enabled = false;
        explosionVFX.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
