using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float Velocidad = 0.3f;
    Vector2 Fondo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovimientoFondo();

    }

    void MovimientoFondo()
    {
        Fondo += new Vector2(Time.deltaTime * Velocidad, 0);

        GetComponent<Renderer>().material.mainTextureOffset = Fondo;
    }
}
