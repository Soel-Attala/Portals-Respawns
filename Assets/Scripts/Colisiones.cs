using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    Vector3 escalaInicial;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        escalaInicial = transform.localScale;
    }

    void OnTriggerEnter(Collider col) 
    {
        if(col.transform.gameObject.name == "BumpWall") 
        {
            Debug.Log("colisione con la pared dorada");
            
        }

        if(col.transform.gameObject.name == "Floor")
        {
            Debug.Log("colisionaste con el piso");
        }

        if(col.transform.gameObject.name == "ShrinkerWall")
        {
            ReducirEscalaJugador();
            Debug.Log("colisionaste con el portal");
            if(localScale = Vector3(0.5f, 0.5f, 0.5f))
            {
                RestaurarEscala();
            }

        }
        
        void ReducirEscalaJugador() 
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        void RestaurarEscala()
        {
            transform.localScale = escalaInicial;

        }


    }
}
