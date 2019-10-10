using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAnzanas : MonoBehaviour
{

    public GameObject[] Manzanas;
    public Queue<GameObject> ManzanasCola = new Queue<GameObject>();
    public static MAnzanas manzanas;
    // Start is called before the first frame update
    void Start()
    {
        manzanas = this;
        foreach (GameObject g in Manzanas)
        {
            ManzanasCola.Enqueue (g);
            g.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void reducirManzana()

    { 
        GameObject g = ManzanasCola.Dequeue ();
        g.gameObject.SetActive(false);
        ManzanasCola.Enqueue (g);

    }

   

}    


