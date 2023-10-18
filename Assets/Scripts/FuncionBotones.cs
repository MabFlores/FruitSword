using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuncionBotones : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Nivel Principal", LoadSceneMode.Single);
        
    }
}
