using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesJugador : MonoBehaviour
{
    Vector3 escalaInicial;
     

    void Start()
    {
        escalaInicial = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
       
    }



    void OnTriggerEnter(Collider col)
    {
        if (col.transform.gameObject.name == "BumpWall")
        {
            Debug.Log("colisione con la pared dorada");

        }

        if (col.transform.gameObject.name == "Floor")
        {
            Debug.Log("colisionaste con el piso");
        }       
    }

    void OnTriggerExit(Collider col)
    {
        if (col.transform.gameObject.name == "ShrinkerWall")
        {
            ReducirEscala();
            Debug.Log("colisionaste con el portal");
        }
    }



    void ReducirEscala()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    void RestaurarEscala()
    {
        transform.localScale = escalaInicial;
    }
}