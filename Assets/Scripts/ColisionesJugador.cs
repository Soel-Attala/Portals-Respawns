using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesJugador : MonoBehaviour
{
    Vector3 escalaInicial;
    Vector3 nuevaEscala;
     

    void Start()
    {
        escalaInicial = transform.localScale = new Vector3(1,1,1);
        nuevaEscala = escalaInicial;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerExit(Collider col)
    {
        if (col.transform.gameObject.name == "ShrinkerWall")
        {
            Debug.Log("colisionaste con el portal");

            if(nuevaEscala == escalaInicial)
            {
                ReducirEscala();
            }

            if (col.transform.gameObject.name == "BumpWall")
            {
                Debug.Log("colisione con la pared dorada");

            }

            if (nuevaEscala != escalaInicial)
            {
                RestaurarEscala();
            }
        }
    }
    



    void ReducirEscala()
    {
        nuevaEscala = transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    void RestaurarEscala()
    {
        nuevaEscala = transform.localScale = new Vector3(1, 1, 1);
    }
}