using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public float fuerzaSalto;

    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
            Destroy(other.gameObject);
            //rigidBody.AddForce(Vector2.right * fuerzaSalto, ForceMode2D.Impulse);

        
    }
}
