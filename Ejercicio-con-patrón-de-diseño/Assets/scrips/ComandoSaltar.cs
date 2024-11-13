using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandoSaltar : IComando
{
 private Jugador jugador;

    public ComandoSaltar(Jugador jugador)
    {
        this.jugador = jugador;
    }

    public void Ejecutar()
    {
        jugador.Saltar();
    }
}
