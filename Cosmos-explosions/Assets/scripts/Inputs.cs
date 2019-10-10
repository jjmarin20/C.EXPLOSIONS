using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    public float movSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(transform.up * 1 * movSpeed * Time.deltaTime);

}
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(transform.up * -1 * movSpeed * Time.deltaTime);
        }
    }
}