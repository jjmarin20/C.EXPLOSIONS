using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private Collider myCollider;

    public int damage = 1;

    // Start is called before the first frame update
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        if (myRigidbody != null)
        {

            myCollider = GetComponent<Collider>();

            if (myCollider != null)
            {
                myCollider.isTrigger = false;
            }
        }
        else
        {
            AutoDestroy();
        }
    }

    private void AutoDestroy()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision col)
    {
        AutoDestroy();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }

    }
}
