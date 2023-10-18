using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "manzana")
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
        //rigidBody.AddForce(Vector2.right * fuerzaSalto, ForceMode2D.Impulse);


    }
}
