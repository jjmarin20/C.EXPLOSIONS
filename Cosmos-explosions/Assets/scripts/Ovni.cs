using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovni : MonoBehaviour

{
    public Vector3 direction;


    void Start()
    {

    }


    void Update()
    {
        transform.Translate(transform.forward * Input.GetAxis("Horizontal") * 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            Destroy(other.gameObject);
        }
    }
}
