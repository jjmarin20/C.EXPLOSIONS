using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform BulletSpawnPosition;
    public Rigidbody Bullet;
    public float movementSpeed = 5F;
    private float movementValue = 0F;
    public float force = 5F;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            FireBullet();
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime);
        }

    }
    protected void FireBullet()
    {
        Rigidbody BulletClone = Instantiate<Rigidbody>(Bullet, BulletSpawnPosition.position, BulletSpawnPosition.rotation);

        BulletClone.AddForce(transform.right * force, ForceMode.Impulse);
    }

}
