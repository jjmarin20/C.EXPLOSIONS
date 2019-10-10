using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Panel1;

    public GameObject Panel2;
  
    void Start()
    {
        Panel1.SetActive(false);

        Panel2.SetActive(false);
    }


    void Update()
    {
        
    }

    public void AbrirPanel()
    {
        Panel1.SetActive(true);
        
        Panel2.SetActive(true);
    }

    public void CambiarDeEscena()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void Cerrarpaneles()
    {
        Panel1.SetActive(false);

        Panel2.SetActive(false);
    }
}
