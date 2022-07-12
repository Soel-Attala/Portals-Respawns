using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BumpWall : MonoBehaviour
{
    Vector3 posInicial;
    public float tiempo = 2f;
    int numeroRandom = 0;
    public float tiempoRestante;
   

   

    void Start()
    {
        posInicial = transform.position;       
        RestearTemporizador();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MoverPared()
    {
        numeroRandom = Random.Range(0, 20);
        posInicial = transform.position = new Vector3(numeroRandom, numeroRandom, numeroRandom);
    }

    void OnTriggerStay(Collider col)
    {
        if (col.transform.gameObject.name == "Player")
        {
            Temporizador();
        }      
    }
 
    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if(tiempoRestante <= 0)
        {
            MoverPared();
            RestearTemporizador();
        }
    }

    void RestearTemporizador()
    {
        tiempoRestante = tiempo;
    }


}
