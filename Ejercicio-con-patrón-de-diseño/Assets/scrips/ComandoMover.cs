using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandoMover : IComando
{

    private Jugador jugador;
    private Vector3 direccion;

    public ComandoMover(Jugador jugador, Vector3 direccion)
    {
        this.jugador = jugador;
        this.direccion = direccion;
    }

    public void Ejecutar()
    {
        jugador.Mover(direccion);
    }
}
