using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandoMover : IComando
{

    private Jugador jugador;

    public ComandoMover(Jugador jugador)
    {
        this.jugador = jugador;
    }

    public void Ejecutar()
    {
        jugador.Mover();
    }
}
