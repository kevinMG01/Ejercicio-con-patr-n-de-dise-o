using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandoAtacar : IComando
{
 private Jugador jugador;

    public ComandoAtacar(Jugador jugador)
    {
        this.jugador = jugador;
    }

    public void Ejecutar()
    {
        jugador.Atacar();
    }
}
