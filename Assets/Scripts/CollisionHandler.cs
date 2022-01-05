using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Die());
    }


    IEnumerator Die()
    {
        GetComponent<PlayerController>().enabled = false;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
