using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amenaza : MonoBehaviour
{

public Rigidbody meteorito;
public Transform spawnPosition;

public Vector3 direction;
public float force;
public float movSpeed = 0.3F;
public float timeSpawn;

private void shootmeteorito()
{
    Rigidbody meteoritoClone =
        Instantiate<Rigidbody>(meteorito, spawnPosition.position, spawnPosition.rotation);

    meteoritoClone.AddForce(direction * force, ForceMode.Impulse);

}

// Start is called before the first frame update
void Start()
{
    InvokeRepeating("shootmeteorito", 5F, timeSpawn);
}
}