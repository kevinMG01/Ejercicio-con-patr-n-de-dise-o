using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public void Mover()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 5);
    }

    public void salto()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    public void atacar()
    {
        Debug.Log("el jugador esta atacando");
    }

}
