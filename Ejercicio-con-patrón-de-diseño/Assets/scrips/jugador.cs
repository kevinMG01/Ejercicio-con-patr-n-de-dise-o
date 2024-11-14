using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 10f;
    public void Mover(Vector3 direccion)
    {
        Debug.Log("el jugador esta moviendose");
        transform.Translate(direccion * velocidad* Time.deltaTime);
    }

    public void Saltar()
    {
        Debug.Log("el jugador esta saltando");
        GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    public void Atacar()
    {
        Debug.Log("el jugador esta atacando");
    }

}
