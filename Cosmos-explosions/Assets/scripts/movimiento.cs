using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimiento : MonoBehaviour
{
    //Movimiento
    public KeyCode MoveL;
    public KeyCode MoveR;

    public float VelocidadVertical = 0;
    public int laneNum = 2;
    public string controlLocked = "n";
    //Vida
    public static int vidas = 3;
    public int vidaPublic;
    public bool puedeHacerDano = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, VelocidadVertical, 0);

        if ((Input.GetKeyDown(MoveL)) && (laneNum > 1) && (controlLocked == "n"))
        {
            VelocidadVertical = 3;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }
        if ((Input.GetKeyDown(MoveR)) && (laneNum < 3) && (controlLocked == "n"))
        {
            VelocidadVertical = -3;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }

        //Vidas
        vidaPublic = vidas;

    }

    //Vida
    public void OnTriggerEnter(Collider col)
    {
        if (!puedeHacerDano)
            return;

        {
            puedeHacerDano = false;
            Invoke("ActivarDano", 1);
            vidas -= 1;

            if (MAnzanas.manzanas != null)
            {
                MAnzanas.manzanas.reducirManzana();
            }

            if (vidas <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Over", LoadSceneMode.Single);
            }
        }

    }

    void ActivarDano()
    {
        puedeHacerDano = true;
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(0.5f);
        VelocidadVertical = 0;
        controlLocked = "n";

    }

}
    