using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzana : MonoBehaviour
{
    public float velocidad;
    public Transform player;
    public Rigidbody2D rb2D;

    private void Start()
    {
        //InvokeRepeating("VelocidadManzana", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 objetivo = new Vector2(player.position.x, player.position.y);
        Vector2 nuevaPos = Vector2.MoveTowards(rb2D.position, objetivo, velocidad * Time.deltaTime);
        rb2D.MovePosition(nuevaPos);
    }

    /*void VelocidadManzana()
    {
        velocidad += 2;
    }*/
    
}
