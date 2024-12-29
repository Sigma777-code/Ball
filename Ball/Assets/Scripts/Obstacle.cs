using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().Respawn();
            //int activScene = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(activScene);
        }
    }











}
