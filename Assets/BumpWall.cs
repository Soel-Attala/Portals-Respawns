using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    Vector3 posInicial;

    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MoverPared()
    {
        posInicial = transform.position = new Vector3(-0.4f, 8.265f, 10);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.gameObject.name == "Player")
        {
            MoverPared();
        }

               
    }


}
