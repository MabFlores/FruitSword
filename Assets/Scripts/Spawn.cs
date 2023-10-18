using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //int x = 5;
    public Transform[] spawnPoints;
    public GameObject enemigo;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnear", 0, 3);
        //InvokeRepeating("velocidad", 5, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnear()
    {
        int i = Random.Range(0, 5);
        Instantiate(enemigo, spawnPoints[i].position, transform.rotation);
    }
    /*void velocidad()
    {
        if (x >= 1)
        {
            x-=1;
        }
    }*/

}
